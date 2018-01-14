using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLL.Repository.Repository;

namespace IsaretDili_UI
{
    public partial class FrmArsiv : Form
    {
        public FrmArsiv()
        {
            InitializeComponent();
        }

        #region FORM LOAD

        private void FrmArsiv_Load(object sender, EventArgs e)
        {
            CategoriesView();
            GifNameView();
        }

        #endregion

        ////////////////////////////////////////////////////////

        #region METHODS

        private void CategoriesView()
        {
            try
            {
                lstCategories.Items.Clear();
                List<Categories> lst = new CategoriesRepo().GetAll();
                foreach (Categories item in lst)
                {
                    lstCategories.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        private void GifNameView()
        {
            try
            {
                lstGifName.Items.Clear();
                List<GifNames> lst = new GifNamesRepo().GetAll().OrderBy(x => x.GifName).ToList();
                foreach (GifNames item in lst)
                {
                    lstGifName.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        #endregion

        ////////////////////////////////////////////////////////

        #region TEXTBOXS SEARCH

        private void txtCategoriesSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstCategories.Items.Clear();
                string arama = txtCategoriesSearch.Text.ToLower();
                List<Categories> lst = new CategoriesRepo().GetAll().Where(x => x.CategoryName.ToLower().Contains(arama)).ToList();
                foreach (Categories item in lst)
                {
                    lstCategories.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        private void txtGifNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstGifName.Items.Clear();
                string arama = txtGifNameSearch.Text.ToLower();
                List<GifNames> lst = new GifNamesRepo().GetAll().Where(x => x.GifName.ToLower().Contains(arama)).ToList();
                foreach (GifNames item in lst)
                {
                    lstGifName.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        #endregion

        ////////////////////////////////////////////////////////

        #region SELECTED INDEX CHANGED

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstGifName.Items.Clear();
                int categoryId = (lstCategories.SelectedItem as Categories).CategoryID;
                List<GifNames> lst = new GifNamesRepo().GetAll().Where(x => x.CategoryID == categoryId).ToList();
                foreach (GifNames item in lst)
                {
                    lstGifName.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        private void lstGifName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string gifName = (lstGifName.SelectedItem as GifNames).GifName;
                lblGifName.Text = gifName;
                object imageName = Properties.Resources.ResourceManager.GetObject(gifName);
                picBoxGif.Image = (Image)imageName;
                lblGifName.ForeColor = Color.ForestGreen;
            }
            catch
            {

            }
        }

        #endregion

        ////////////////////////////////////////////////////////

        #region CLICKS

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            CategoriesView();
            GifNameView();
            lstGifName.SelectedItem = -1;
            lstCategories.SelectedItem = -1;
        }

        #endregion

    }
}
