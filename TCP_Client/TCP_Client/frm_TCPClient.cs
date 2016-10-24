/* File name: frm_TCPClient.cs
 * Description:
 * TCP Client.
 * Display a SVG image and shows its properties.
 * Date: May 13th, 2016.
 * Autor: Elisabet Gonzalez
 * Version: 1.0.
 * 
 * History:
 * v1.0     13/05/2016  SVG displayed.
 * v1.1     13/05/2016  Comments and connection code added.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class frm_TCPClient : Form
    {
        private string selectedPath;
        private Svg.SvgDocument svgDocument;

        public frm_TCPClient()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult selectResult = filePicker.ShowDialog();
            if(selectResult == DialogResult.OK)
            {
                SVGParser.MaximumSize = new Size(pb_svg.Width, pb_svg.Height);
                selectedPath = filePicker.FileName;
                txt_loadSVG.Text = selectedPath;
                svgDocument = SVGParser.GetSvgDocument(selectedPath);
                txt_width.Text = svgDocument.Width.Value.ToString();
                txt_height.Text = svgDocument.Height.Value.ToString();
                pb_svg.Image = SVGParser.GetBitmapFromSVG(selectedPath);
            }
        }
    }
}
