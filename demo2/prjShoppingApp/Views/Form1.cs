﻿using prjShoppingApp.Models;
using prjShoppingApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjShoppingApp
{
    public partial class Form1 : Form
    {
        private tCustomer _user;
        private tProduct _product;
        private List<tProduct> _allProducts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            _user = f.loginUser;
            this.Text = _user.fName + ", 您好";
            displayAll();
        }

        private void displayAll()
        {
            flowLayoutPanel1.Controls.Clear();
            dbDemoEntities db = new dbDemoEntities();
            var datas=from p in  db.tProduct
                      select p;
            _allProducts=datas.ToList();
            foreach (var r in datas)
            {
                ProductBox x = new ProductBox();
                x.product = r;
                x.addToCart += this.addToCart;
                x.Width= 180;
                flowLayoutPanel1.Controls.Add(x);
            }
        }

        private void addToCart(tProduct p)
        {
            _product = p;
            label1.Text=_product.fName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tShoppingCart x= new tShoppingCart();
            x.fProductId = _product.fId;
            x.fCustomerId=_user.fId;
            x.fCount = 1;

            dbDemoEntities db= new dbDemoEntities();
            db.tShoppingCart.Add(x);
            db.SaveChanges();

            label1.Text = "加入購物車成功";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                showShoppingCartItems();
        }

        private void showShoppingCartItems()
        {
            var cart = (new dbDemoEntities()).tShoppingCart.Where(t => t.fCustomerId == _user.fId);
            List<CShoppingCartItem> list=new List<CShoppingCartItem>();
            foreach (var t in cart)
            {
                CShoppingCartItem c = new CShoppingCartItem();
                tProduct p = _allProducts.FirstOrDefault(p2 => p2.fId == t.fProductId);
                c.productName=p.fName;
                c.count = (int)t.fCount;
                c.price=(decimal)p.fPrice;
                list.Add(c);
            }
            dataGridView1.DataSource = list;
            label4.Text ="交易金額：＄"+ list.Sum(t=>t.pay).ToString("###,###,##0");
            label3.Text = "稅　　額：＄" + (list.Sum(t => t.pay)*0.05M).ToString("###,###,##0");           
            label2.Text = "應付金額：＄" + (list.Sum(t => t.pay) * 1.05M).ToString("###,###,##0");

        }
    }
}