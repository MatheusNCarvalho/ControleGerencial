using Microsoft.Reporting.WebForms;
using ProjetoFlavio.Reports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ProjetoFlavio.Reports.DataSet1;

namespace ProjetoFlavio.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {

            DataSetImagem dataSetImagem = new DataSetImagem();
            DataSet2 dataSetDadosClientes = new DataSet2();
            var id = 11;

            
            var connectionString = ConfigurationManager.ConnectionStrings["projetoConnectionString"].ConnectionString;

            SqlConnection conx = new SqlConnection(connectionString);

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM clientes as c Join clientes_enderecos as ce on c.ClienteId = ce.EnderecoId  where ClienteId =" + id+"", conx);
            // SqlDataAdapter adp = new SqlDataAdapter("SELECT *  FROM imagens ", conx);
             adp.Fill(dataSetDadosClientes, dataSetDadosClientes.clientes.TableName);

            adp.Dispose();
            //SqlDataAdapter adp3 = new SqlDataAdapter("SELECT * FROM clientes as c Join clientes_enderecos as ce on c.ClienteId = ce.EnderecoId  where ClienteId =" + id + "", conx);
             SqlDataAdapter adp3 = new SqlDataAdapter("SELECT *  FROM imagens ", conx);
            adp3.Fill(dataSetImagem, dataSetImagem.imagens.TableName);
            adp3.Dispose();


            var viewer = new Microsoft.Reporting.WebForms.ReportViewer();
            viewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            viewer.LocalReport.EnableExternalImages = true;

          

           // viewer.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("ReportParameter1", "Matheus"));


            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\teste.rdlc";
            //viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", ds.Tables[0])); ds.relatorio.Where(m => m.ClienteId == id).FirstOrDefault())
            viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", dataSetImagem.Tables[0]));
            viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetDados", dataSetDadosClientes.Tables[0]));
            //viewer.ReportRefresh(); 

            viewer.SizeToReportContent = true;
            viewer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
            viewer.Height = System.Web.UI.WebControls.Unit.Percentage(100);

            
            ViewBag.ReportViewer = viewer;


           

            return View();

           


        }

    }
}