using CentroDeportivo1E.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeportivo1E.Services;

namespace CentroDeportivo1E.Forms
{
    public partial class FormListaSocios : Form
    {
        SocioService socioService = new SocioService();
        public FormListaSocios()
        {
            InitializeComponent();
        }



    }
}