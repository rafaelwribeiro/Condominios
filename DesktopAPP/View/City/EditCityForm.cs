using DesktopAPP.Model;
using DesktopAPP.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopAPP.View.City
{
    public partial class EditCityForm : Form
    {
        private List<string> states;
        private CityModel city;
        private bool IsInsert;
        private CityService cityService;

        public EditCityForm()
        {
            InitializeComponent();
            city = new CityModel();
            IsInsert = true;
            Init();
        }

        public EditCityForm(CityModel model)
        {
            InitializeComponent();
            this.city = model;
            IsInsert = false;
            Init();
        }

        private void Init()
        {
            cityService = CityService.GetInstance();
            states = new List<string>()
            {
                ""  , //selecione
                "AC", // Acre
                "AL", // Alagoas
                "AP", // Amapá
                "AM", // Amazonas
                "BA", // Bahia
                "CE", // Ceará
                "DF", // Distrito Federal
                "ES", // Espírito Santo
                "GO", // Goiás
                "MA", // Maranhão
                "MT", // Mato Grosso
                "MS", // Mato Grosso do Sul
                "MG", // Minas Gerais
                "PA", // Pará
                "PB", // Paraíba
                "PR", // Paraná
                "PE", // Pernambuco
                "PI", // Piauí
                "RJ", // Rio de Janeiro
                "RN", // Rio Grande do Norte
                "RS", // Rio Grande do Sul
                "RO", // Rondônia
                "RR", // Roraima
                "SC", // Santa Catarina
                "SP", // São Paulo
                "SE", // Sergipe
                "TO"  // Tocantins
            };
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                city.State = city.State.ToUpper();
                if (IsInsert)
                    await cityService.Post(city);
                else
                    await cityService.Update(city);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                MessageBox.Show($"Falha ao {(IsInsert ? "Cadastrar" : "Atualizar")} cidade. \n{ex.Message}");
            }
        }

        private void EditCityForm_Load(object sender, EventArgs e)
        {
            LoadStates();

            txtId.DataBindings.Add("Text", city, "Id");
            txtName.DataBindings.Add("Text", city, "Name");
            cmbState.DataBindings.Add("Text", city, "State");

        }

        private void LoadStates()
        {
            states.ForEach(x => { cmbState.Items.Add(x); });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();

        }
    }
}
