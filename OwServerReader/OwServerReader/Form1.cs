using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OwServerReader
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnRead_Click(object sender, EventArgs e)
    {
      XElement xelement = XElement.Load("http://skaola.se:85/details.xml");
      IEnumerable<XElement> owds = xelement.Elements().Elements();

      txtXML.Text = "";

      // Read the entire XML
      foreach (var owd in owds)
      {
        if (owd.Name.LocalName == "ROMId")
        {
          txtXML.Text += /*owd.Name.LocalName + " - " +*/ owd.Value + ",";
        }
        else if (owd.Name.LocalName == "PrimaryValue")
        {
          txtXML.Text += /*owd.Name.LocalName + " - " +*/ ConvertTemp(owd.Value) + Environment.NewLine;
        }
      }

    }

    private string ConvertTemp(string value)
    {
      string[] split = value.Split(' ');
      string s = split[0];

      return s;
    }

  }
}
