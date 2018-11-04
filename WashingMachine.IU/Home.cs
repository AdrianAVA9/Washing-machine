using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashingMachine.Entity;

namespace WashingMachine.IU
{
    public partial class Home : Form
    {
        public List<Washingmachine> listMachine = new List<Washingmachine>();
        public ClientMachine _Client;
        public Washingmachine machineSelected = null;
        private delegate void InvokeDelegate();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadTypeOfClothing();
            ShowPublicity(true);
        }

        private void loadTypeOfClothing()
        {
            int ControlsWithinPanelTypeOfClothing = panelTypeOfClothing.Controls.Count;
            RadioButton controlRadioButton;

            var values = Enum.GetValues(typeof(TypeOfClothing));

            foreach (var item in values)
            {
                if (!Enum.GetName(typeof(TypeOfClothing), 5).Equals(item.ToString()))
                {
                    panelTypeOfClothing.Controls.Add(controlRadioButton = new NewTypeOfRadioButton(
                        item.ToString(),
                        convertToNewFormat(item.ToString()),
                        3, (ControlsWithinPanelTypeOfClothing * 25)));

                    ControlsWithinPanelTypeOfClothing++;
                }
            }
        }

        private string convertToNewFormat(string value)
        {
            StringBuilder newFormat = new StringBuilder();

            if (value == null)
                return "";

            foreach (var item in value)
            {
                if (char.IsUpper(item))
                    newFormat.Append(string.Concat(" " + item));
                else
                    newFormat.Append(item);
            }

            return newFormat.ToString().ToUpper();
        }

        private void btnAddNewMachine_Click(object sender, EventArgs e)
        {
            Washingmachine machine;
            listMachine.Add(machine = new Washingmachine());
            MachineContainer.Controls.Add(getButton(machine));

        }

        private Button getButton(Washingmachine objWM)
        {
            Button button = new NewTypeOfButton(objWM.SerialNumber, 3, ((listMachine.Count - 1) * 30), String.Concat("btn", objWM.SerialNumber));
            button.Click += MachineSelected_Click;
            return button;
        }

        private void MachineSelected_Click(object sender, EventArgs e)
        {
            Button ObjBtn = ((Button)sender);
            if (publicity.Visible) { ModifyVisibleProperty(publicity); }
            SearchMachine(ObjBtn.Text);
            ShowInformation();
            _Client = ClientMachine.getClientAndInitializeItsAtributes(machineSelected);
        }

        private void ModifyVisibleProperty(Control control)
        {
            if (control.Visible) { control.Visible = false; } else { control.Visible = true; }
        }

        private void SearchMachine(string serialNumber)
        {
            machineSelected = listMachine.FirstOrDefault(washingmachine => washingmachine.SerialNumber.Equals(serialNumber));
        }

        private void ShowInformation()
        {
            IsMachineTurnON();
            ModifyTimer();
            ModifyDetergent();
            ModifyLevelWater();
            ModifySerialNumber();
            setInformationAboutClothing();
        }

        private void IsMachineTurnON()
        {
            if (machineSelected.TurnOn)
            {
                ChangeStyle(TurnON);
                RemoveStyle(TurnOFF);
            }
            else
            {
                ChangeStyle(TurnOFF);
                RemoveStyle(TurnON);
            }
        }

        private void ChangeStyle(Control control)
        {
            control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
        }

        private void RemoveStyle(Control control)
        {
            control.ForeColor = System.Drawing.Color.White;
        }

        private void ModifyTimer()
        {
            lblRealTime.Text = machineSelected.ShowStatusOfWashing();
        }

        private void ModifyDetergent()
        {

            if (!machineSelected.Detergent)
            {
                lblDetergent.Text = "Does not have";
            }
            else
            {
                lblDetergent.Text = "It has detergent";
            }
        }
        private void ModifyLevelWater()
        {
            lblWater.Text = string.Concat(machineSelected.MachineWaterLevel, "%");
        }
        private void ModifySerialNumber()
        {

            SerialNumber.Text = machineSelected.SerialNumber;
        }

        private void setInformationAboutClothing()
        {
            if (machineSelected.Clothes != null)
            {
                Clothes clothing = machineSelected.Clothes;
                TypeClothing.Text = convertToNewFormat(clothing.InitialTypeOfClothing.ToString());
                WashingTime.Text = machineSelected.ShowInitialTimeOfWashing();
                stateInWhichItIs.Text = convertToNewFormat(clothing.TypeOfClothingInWashingTime.ToString());
            }
            else
            {
                TypeClothing.Text = "You have not loaded the type of clothing";
                WashingTime.Text = "0 min";
                stateInWhichItIs.Text = "none";
            }
        }

        private void loadDetergent_Click(object sender, EventArgs e)
        {
            if (!machineSelected.Detergent)
            {
                _Client.ExecuteCommand("LOADDETERGENT");
                ModifyDetergent();
            }
        }

        private void TurnON_Click(object sender, EventArgs e)
        {
            if (!machineSelected.TurnOn)
            {
                _Client.ExecuteCommand("ON");
                IsMachineTurnON();
            }
        }

        private void TurnOFF_Click(object sender, EventArgs e)
        {
            if (machineSelected.TurnOn)
            {
                try
                {
                    _Client.ExecuteCommand("OFF");
                    IsMachineTurnON();
                }
                catch (Exception ex)
                {
                    ShowExceptionInformation("Turn machine off", ex.Message, "Information");
                }
            }
        }

        private string getValue(string keyString)
        {
            int key = -1;
            var values = Enum.GetValues(typeof(TypeOfClothing));

            foreach (var value in values)
            {
                if (value.ToString().Equals(keyString))
                {
                    key = (int)value;
                    return Convert.ToString(key);
                }
            }
            return Convert.ToString(key);
        }


        private void ShowPublicity(bool status)
        {
            publicity.Visible = status;
            publicity.BringToFront();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            LoadClothes();
        }

        private void LoadClothes()
        {
            try
            {
                bool IsThereAnySelected = false;
                string key = "";

                foreach (RadioButton radioButton in panelTypeOfClothing.Controls)
                {
                    if (radioButton.Checked)
                    {
                        key = getValue(radioButton.Name);
                        _Client.ExecuteCommand("LOADCLOTHES", key);
                        setInformationAboutClothing();
                        panelLoadClothes.Visible = false;
                        radioButton.Checked = false;
                        IsThereAnySelected = true;
                    }
                }

                if (!IsThereAnySelected) { ShowExceptionInformation("Load clothing", "Please select any type of clothing", "Information"); }
            }
            catch (Exception ex)
            {
                ShowExceptionInformation("Error", ex.Message, "Error");
            }
        }

        private void ShowExceptionInformation(string exceptionName, string exceptionDescription, string typeException)
        {
            ShowException exception = new ShowException(exceptionName, exceptionDescription, typeException);
            exception.ShowDialog();
            exception.BringToFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelLoadClothes.Visible = false;
            deselectTheRadioButton();
        }

        private void deselectTheRadioButton()
        {
            foreach (RadioButton control in panelTypeOfClothing.Controls)
            {
                if (control.Checked)
                    control.Checked = false;
            }
        }

        private async void btnLoadWater_Click(object sender, EventArgs e)
        {
            try
            {
                var LoadWater = _Client.ExecuteCommandAsync("LOADWATER");
                var showStatus = ShowStatusOfMachineWaterLevel();
                hideStatusOfLoad();
                await Task.WhenAll(LoadWater, showStatus);
                hideStatusOfLoad();
            }
            catch (Exception ex)
            {
                hideStatusOfLoad();
                ShowExceptionInformation("Washing-machine state", ex.Message, "Information");
            }
        }
        private async Task ShowStatusOfMachineWaterLevel()
        {
            while (machineSelected.WaterSupply)
            {
                await ControlBeginInvoke(lblWater, new InvokeDelegate(ChangeLevel));
            }
        }
        private async Task ControlBeginInvoke(Label label, InvokeDelegate invokeDelegate)
        {
            await Task.Delay(250).ContinueWith((t) =>
            {
                label.BeginInvoke(invokeDelegate);
            });
        }
        private void ChangeLevel()
        {
            lblWater.Text = String.Format(machineSelected.MachineWaterLevel + "%");
        }

        private void hideStatusOfLoad()
        {
            ModifyVisibleProperty(lblFilling);
            ModifyVisibleProperty(btnStopFilling);
        }

        private void btnSpecifyTime_Click(object sender, EventArgs e)
        {
            TimePanel.Visible = true;
            TimePanel.BringToFront();
        }

        private async void BtnLoadTime_Click(object sender, EventArgs e)
        {
            int minutes = (txtMinutes.TextLength == 0) ? 0 : Convert.ToInt32(txtMinutes.Text);
            int seconds = (txtSeconds.TextLength == 0) ? 0 : Convert.ToInt32(txtSeconds.Text);

            if (minutes < 60 && seconds < 60)
            {
                try
                {
                    CleanTextbox();
                    TimePanel.Visible = false;
                    DateTime time = new DateTime()
                        .AddMinutes(minutes)
                        .AddSeconds(seconds);

                    var startWashing = _Client.ExecuteCommandAsync("STARTWASHING", Convert.ToString(time));
                    var showTimer = showTimerInWashingTime();
                    WashingTime.Text = machineSelected.ShowInitialTimeOfWashing();
                    await Task.WhenAll(showTimer, startWashing);
                }
                catch (Exception ex)
                {
                    WashingTime.Text = "00:00:00";//machineSelected.ShowInitialTimeOfWashing();
                    ShowExceptionInformation("Washing-machine state", ex.Message, "Information");
                }
            }
            else
            {
                ShowExceptionInformation("Washing-machine state", "The time entered is invalid", "Information");
            }
        }
        private async Task showTimerInWashingTime()
        {
            while (machineSelected._Motor)
            {
                var timerOfWashing = ControlBeginInvoke(lblRealTime, new InvokeDelegate(ShowTimerOfWashing));
                var statusOfClothing = ControlBeginInvoke(stateInWhichItIs, new InvokeDelegate(ShowStatusOfClothing));
                await Task.WhenAll(timerOfWashing, statusOfClothing);
            }
        }

        private void ShowStatusOfClothing()
        {
            stateInWhichItIs.Text = convertToNewFormat(machineSelected.Clothes?.TypeOfClothingInWashingTime.ToString());
        }

        private void ShowTimerOfWashing()
        {
            lblRealTime.Text = machineSelected.ShowStatusOfWashing();
        }

        private void BtnCancelTime_Click(object sender, EventArgs e)
        {
            CleanTextbox();
            TimePanel.Visible = false;
        }

        private void CleanTextbox()
        {
            txtMinutes.Text = "";
            txtSeconds.Text = "";
        }

        private void EnterMinutes(object sender, KeyPressEventArgs e)
        {
            e.Handled = EnterTime(txtMinutes, e);
        }

        private void EnterSeconds(object sender, KeyPressEventArgs e)
        {
            e.Handled = EnterTime(txtSeconds, e);
        }

        private bool EnterTime(TextBox textBox, KeyPressEventArgs e)
        {
            return (char.IsNumber(e.KeyChar) && textBox.TextLength < 2 || char.IsControl(e.KeyChar)) ? false : true;
        }

        private async void btnDry_Click(object sender, EventArgs e)
        {
            DrainConfiguration("Draining");
            var drainCmd = _Client.ExecuteCommandAsync("DRY");
            var statusWaterLevel = ShowStatusOfWaterLevel();
            await Task.WhenAll(drainCmd, statusWaterLevel);

            ShowInformation();
            DrainConfiguration("Filling");
        }
        private async Task ShowStatusOfWaterLevel()
        {
            while (machineSelected.MachineWaterLevel > 0)
            {
                await ControlBeginInvoke(lblWater, new InvokeDelegate(ChangeLevel));
            }
        }
        private void DrainConfiguration(string state)
        {
            lblFilling.Text = state;
            ModifyVisibleProperty(lblFilling);
        }

        private void btnLoadClothe_Click(object sender, EventArgs e)
        {
            panelLoadClothes.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStopFilling_Click(object sender, EventArgs e)
        {
            machineSelected.TurnOffWaterSupply();
        }

        private async void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                var pauseAction = _Client.ExecuteCommandAsync("PAUSE");
                var timer = showTimerInWashingTime();

                await Task.WhenAll(pauseAction, timer);
            }
            catch (Exception ex)
            {
                ShowExceptionInformation("Information", ex.Message, "Information");
            }
        }
    }
}
