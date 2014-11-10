using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTfulClient
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

			setupListResult();
		}

		Service s = new Service();

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				List<Model> m = s.getPerson(txtPhone.Text, txtAddress.Text);				
				fillListResult(m);
				lblCount.Text = m.Count.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//------------------------
		// настройка списка для файлов
		//------------------------   
		private void setupListResult()
		{
			lstViewResult.Columns.Add("Ид");
			lstViewResult.Columns.Add("Телефон");
			lstViewResult.Columns.Add("Ф.И.О.");			
			lstViewResult.Columns.Add("Улица");
			lstViewResult.Columns.Add("Дом");
			lstViewResult.Columns.Add("Квартира");			
			lstViewResult.GridLines = true;
			lstViewResult.FullRowSelect = true;
			lstViewResult.MultiSelect = false;
			lstViewResult.SmallImageList = imageList_small;
			lstViewResult.LargeImageList = imageList_small;

			lstViewResult.View = View.Details;
			lstViewResult.Columns[0].Width = 100;
			lstViewResult.Columns[1].Width = 100;
			lstViewResult.Columns[2].Width = 200;
			lstViewResult.Columns[3].Width = 200;
			lstViewResult.Columns[4].Width = 100;
			lstViewResult.Columns[5].Width = 100;
		}

		//------------------------
		// загружаем файлы в список
		//------------------------   
		public void fillListResult(List<Model> models)
		{
			lstViewResult.Items.Clear();

			foreach(Model model in models)
			{
				ListViewItem items = new ListViewItem(model.Id.ToString());
				items.ImageIndex = 0;
				
				items.SubItems.Add(model.Phone);
				items.SubItems.Add(model.Person);
				items.SubItems.Add(model.Street);
				items.SubItems.Add(model.Building);
				items.SubItems.Add(model.Appartment);
				
				lstViewResult.Items.Add(items);
			}
		}
	}
}
