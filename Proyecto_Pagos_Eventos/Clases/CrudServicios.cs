using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Pagos_Eventos.Models;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Drawing;

namespace Proyecto_Pagos_Eventos.Clases
{
    class CrudServicios
    {
        public static bool docExist = false;
        public static Guid id = Guid.Empty;

        public static void AltaComprobante(Comprobantes array)
        {
            try
            {
                Conexion.getInstance().Comprobantes.Add(array);
                Conexion.getInstance().SaveChanges();
                var i = Conexion.getInstance().Servicio.Join(
                            Conexion.getInstance().Equipo,
                            s => s.idEquipo,
                            e => e.idEquipo,
                            (s, e) => new {s, e
                            }).Where(w => w.s.idServicio == array.idServicio).ToList();
                List<Equipo> equips = new List<Equipo>();
                foreach (var item in i)
                {
                    equips.Add(item.e);
                }
                ComprobantePDF(Conexion.getInstance().Comprobantes.Where(w => w.idComprobante == array.idComprobante).ToList(), equips);
                MessageBox.Show("El Comprobante fue agregado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Object Consulta()
        {
            var tabla = Conexion.getInstance().Clientes
                .Join(
                    Conexion.getInstance().Comprobantes,
                    cl => cl.idCliente,
                    c => c.idCliente,
                    (cl, c) => new { cl, c }
                )
                .Join(
                    Conexion.getInstance().Servicio,
                    clc => clc.c.idServicio,
                    s => s.idServicio,
                    (clc, s) => new { clc, s }
                )
                .Join(
                    Conexion.getInstance().Equipo,
                    clcs => clcs.s.idEquipo,
                    e => e.idEquipo,
                    (clcs, e) => new
                    {
                        e,
                        clcs
                    }
                )
                .Join(
                    Conexion.getInstance().Usuarios,
                    clcse => clcse.clcs.clc.c.idUsuario,
                    u => u.idUsuario,
                    (clcse, u) => new
                    { clcse, u }
                ).GroupBy(g => new {
                    g.clcse.clcs.clc.c.idCliente,
                    g.clcse.clcs.clc.c.idComprobante,
                    g.clcse.clcs.clc.c.idUsuario,
                    g.clcse.clcs.clc.c.idServicio,
                    g.clcse.clcs.clc.c.monto,
                    g.clcse.clcs.clc.c.pagado,
                    g.clcse.clcs.clc.c.activo,
                    g.clcse.clcs.clc.c.fechaInicio,
                    g.clcse.clcs.clc.c.fechaFinal,
                    g.clcse.clcs.clc.cl.nombre,
                    g.clcse.clcs.clc.cl.apellidos,
                    g.clcse.clcs.clc.cl.celular,
                    g.clcse.clcs.clc.cl.correo,
                    g.clcse.clcs.clc.cl.telefono,
                    g.u.usuario
                }).Select(s => new {
                    idComprobante = s.Key.idComprobante,
                    idCliente = s.Key.idCliente,
                    idUsuario = s.Key.idUsuario,
                    cliente = s.Key.nombre + " " + s.Key.apellidos,
                    telefono = s.Key.telefono,
                    celular = s.Key.celular,
                    correo = s.Key.correo,
                    Servicio = s.Key.idServicio,
                    fechaInicio = s.Key.fechaInicio,
                    fechaFinal = s.Key.fechaFinal,
                    monto = s.Key.monto,
                    activo = s.Key.activo,
                    pagado = s.Key.pagado
                }).ToList();
            return tabla;
        }

        public static void ModificarComprobante(Comprobantes array)
        {
            try
            {
                if (!Conexion.getInstance().Servicio.Where(w => w.idServicio == array.idServicio).Equals(true))
                {
                    Guid f = array.idComprobante;
                    Comprobantes modificar = Conexion.getInstance().Comprobantes.Where(w => w.idComprobante == f).FirstOrDefault();
                    modificar.monto = array.monto;
                    modificar.pagado = array.pagado;
                    modificar.activo = array.activo;
                    modificar.fechaFinal = array.fechaFinal;
                    modificar.fechaInicio = array.fechaInicio;
                    modificar.idCliente = array.idCliente;
                    modificar.idServicio = array.idServicio;
                    modificar.idUsuario = array.idUsuario;
                    Conexion.getInstance().SaveChanges();
                    var i = Conexion.getInstance().Servicio.Join(
                            Conexion.getInstance().Equipo,
                            s => s.idEquipo,
                            e => e.idEquipo,
                            (s, e) => new {
                                s,
                                e
                            }).Where(w => w.s.idServicio == array.idServicio).ToList();
                    List<Equipo> equips = new List<Equipo>();
                    foreach (var item in i)
                    {
                        equips.Add(item.e);
                    }
                    ComprobantePDF(Conexion.getInstance().Comprobantes.Where(w => w.idComprobante == array.idComprobante).ToList(), equips);
                    
                    MessageBox.Show("El Comrobante fue modificado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static IEnumerable<Equipo> TraerEquipoD()
        {
            var tabla = Conexion.getInstance().Equipo.Where(w => w.activo == true).ToList();

            return tabla;
        }   

        public static Object TraerEquipoA(Guid id)
        {
            var tabla = (from s in Conexion.getInstance().Servicio
                         join e in Conexion.getInstance().Equipo on s.idEquipo equals e.idEquipo
                         where s.idServicio == id 
                         select new
                         {
                             idEquipo = e.idEquipo,
                             tipo = e.tipo,
                             descripcion = e.descripcion,
                             activo = e.activo,
                             monto = e.monto
                         }).ToList();

            return tabla;
        }

        public static bool verificarComprobante(Guid cliente, DateTime fi, DateTime ff)
        {
            bool i = false;

            var tabla = Conexion.getInstance().Comprobantes.Where(w => w.fechaInicio == fi && w.fechaFinal == ff && w.idCliente == cliente).FirstOrDefault();

            if (tabla != null)
            {
                i = true;
            }
            else
            {
                i = false;
            }

            return i;
        }

        public static void AltaServicio(Servicio array, bool activoCompr)
        {
            try
            {

                Conexion.getInstance().Servicio.Add(array);

                if (activoCompr)
                {
                    Equipo mod = Conexion.getInstance().Equipo.Where(w => w.idEquipo == array.idEquipo).FirstOrDefault();
                    mod.activo = false;
                }
                Conexion.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BajaServicio(Guid idE, Guid idS)
        {
            try
            {
                var registro = Conexion.getInstance().Servicio.Where(w => w.idEquipo == idE && w.idServicio == idS).FirstOrDefault();
                Conexion.getInstance().Servicio.Remove(registro);
                var equipo = Conexion.getInstance().Equipo.Where(w => w.idEquipo == idE).FirstOrDefault();
                equipo.activo = true;
                Conexion.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ComprobantePDF(List<Comprobantes> comp, List<Equipo> eqi)
        {
            try
            {
                string totals = "";
                Document pdf = new Document(PageSize.Letter);// crear documento
                pdf.SetMargins(40f, 40f, 40f, 40f);
                MemoryStream ms = new MemoryStream();
                //FileStream ms = new FileStream("C://Users/Octavio/Documents/test.pdf", FileMode.Create); // instancia para crear documento y ubicacion a guardar PENDIETE CON BD
                PdfWriter witter = PdfWriter.GetInstance(pdf, ms);// generamos la carga del documento PENDIETE CON BD
                pdf.AddAuthor("s65f1s65-s541f5s4-5s46d4f16s" + "C" + "sf54s65df4-s654f65s-65gnb1d5");// agregamos autoria al archivo
                pdf.AddTitle("s65f1s65-s541f5s4-5s46d4f16s");// agregamos nombre al archivo
                pdf.Open();

                BaseFont fuente1 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true); //creamos la fuente que se utilizara en el texto
                BaseFont fuente2 = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, true); //creamos la fuente que se utilizara en el texto

                // creamos estilos para cada tipo de texto
                iTextSharp.text.Font titulo = new iTextSharp.text.Font(fuente2, 28f, iTextSharp.text.Font.BOLD, BaseColor.Black);
                iTextSharp.text.Font cuerpo = new iTextSharp.text.Font(fuente1, 10f, iTextSharp.text.Font.NORMAL, BaseColor.Black);
                iTextSharp.text.Font invoice = new iTextSharp.text.Font(fuente1, 20f, iTextSharp.text.Font.BOLD, BaseColor.White);
                iTextSharp.text.Font topTable = new iTextSharp.text.Font(fuente1, 12f, iTextSharp.text.Font.BOLD, BaseColor.Black);
                iTextSharp.text.Font total = new iTextSharp.text.Font(fuente1, 15f, iTextSharp.text.Font.BOLD, BaseColor.Black);


                // barra espaciadora
                pdf.Add(Chunk.Newline);
                Chunk barra = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(5f, 30f, new BaseColor(Color.Aqua), Element.ALIGN_RIGHT, -1));
                pdf.Add(barra);

                // encabezado del documento
                var encabezado = new PdfPTable(new float[] { 40f, 60f }) { WidthPercentage = 100 };
                encabezado.AddCell(new PdfPCell(new Phrase("Salon de fiestas XY", titulo)) { Border = 0, Rowspan = 3, VerticalAlignment = Element.ALIGN_MIDDLE });
                encabezado.AddCell(new PdfPCell(new Phrase("Av. Las flores #15358 Colonia El Pedregal", cuerpo)) { Border = 0, Padding = 5f, HorizontalAlignment = Element.ALIGN_RIGHT });
                encabezado.AddCell(new PdfPCell(new Phrase("Telefono: 269-5614", cuerpo)) { Border = 0, Padding = 5f, HorizontalAlignment = Element.ALIGN_RIGHT });
                encabezado.AddCell(new PdfPCell(new Phrase("Celular (664) 269-4583", cuerpo)) { Border = 0, Padding = 5f, HorizontalAlignment = Element.ALIGN_RIGHT });
                pdf.Add(encabezado);
                pdf.Add(new Phrase(" "));

                // tabla datos del cliente
                var cliente = new PdfPTable(new float[] { 15f, 43f, 42f }) { WidthPercentage = 100 };
                cliente.AddCell(new PdfPCell(new Phrase("Cliente:", invoice))
                {
                    BorderColor = new BaseColor(Color.Blue),
                    BackgroundColor = new BaseColor(Color.Blue),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    Rowspan = 3
                });
                foreach (var item in comp)
                {
                    var consult = Conexion.getInstance().Documentos.Where(w => w.idComprobante == item.idComprobante).FirstOrDefault();
                    if (!consult.Equals(true))
                    {
                        docExist = false;
                    }
                    else
                    {
                        docExist = true;
                    }
                    id = item.idComprobante;
                    cliente.AddCell(new PdfPCell(new Phrase(String.Format("# Comprobante: {0}", item.idComprobante.ToString()), cuerpo))
                    {
                        BorderWidthBottom = 0,
                        BorderWidthRight = 0,
                        Padding = 5f
                    });
                    cliente.AddCell(new PdfPCell(new Phrase(String.Format("Celular: {0}", item.Clientes.celular), cuerpo))
                    {
                        BorderWidthBottom = 0,
                        BorderWidthLeft = 0,
                        Padding = 5f
                    });
                    cliente.AddCell(new PdfPCell(new Phrase(String.Format("Nombre: {0}", item.Clientes.nombre + " " + item.Clientes.apellidos), cuerpo))
                    {
                        BorderWidthTop = 0,
                        BorderWidthRight = 0,
                        BorderWidthBottom = 0,
                        Padding = 5f
                    });
                    cliente.AddCell(new PdfPCell(new Phrase(String.Format("Fecha inicial: {0}", item.fechaInicio), cuerpo))
                    {
                        BorderWidthTop = 0,
                        BorderWidthLeft = 0,
                        BorderWidthBottom = 0,
                        Padding = 5f
                    });
                    cliente.AddCell(new PdfPCell(new Phrase(String.Format("Teléfono: {0}", item.Clientes.telefono), cuerpo))
                    {
                        BorderWidthTop = 0,
                        BorderWidthRight = 0,
                        Padding = 5f
                    });
                    cliente.AddCell(new PdfPCell(new Phrase(String.Format("Fecha final: {0}", item.fechaFinal), cuerpo))
                    {
                        BorderWidthTop = 0,
                        BorderWidthLeft = 0,
                        Padding = 5f
                    });
                    totals = item.monto.ToString();
                }
                pdf.Add(cliente);
                pdf.Add(new Phrase(" "));

                // tabla de los equipos registrados
                var registro = new PdfPTable(new float[] { 15f, 70f, 15f }) { WidthPercentage = 100 };
                var c1 = new PdfPCell(new Phrase("Tipo", topTable)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(Color.Blue), Padding = 4f };
                var c2 = new PdfPCell(new Phrase("Descripción", topTable)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(Color.Blue), Padding = 4f };
                var c3 = new PdfPCell(new Phrase("Monto", topTable)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(Color.Blue), Padding = 4f };
                registro.AddCell(c1);
                registro.AddCell(c2);
                registro.AddCell(c3);
                c1.Border = 0;
                c2.Border = 0;
                c3.Border = 0;
                foreach (var item in eqi)
                {
                    c1.Phrase = new Phrase(item.tipo);
                    c2.Phrase = new Phrase(item.descripcion);
                    c3.Phrase = new Phrase("$" + item.monto.ToString());
                    registro.AddCell(c1);
                    registro.AddCell(c2);
                    registro.AddCell(c3);
                }
                pdf.Add(registro);
                pdf.Add(new Phrase(" "));

                pdf.Add(new Phrase("Total: $" + totals, total));

                ms.Seek(0, SeekOrigin.Begin);
                witter.Close();
                pdf.Close();

                byte[] file = null;
                file = ms.ToArray();

                if (docExist)
                {
                    var documento = Conexion.getInstance().Documentos.Where(w => w.idComprobante == id).FirstOrDefault();
                    documento.pdf = file;
                }
                else
                {
                    Conexion.getInstance().Documentos.Add(new Documentos { idComprobante = id, pdf = file});
                }
                Conexion.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
