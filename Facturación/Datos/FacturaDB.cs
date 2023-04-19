using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost; user=root; database=factura2; password=123456";


        public bool Guardar(Factura factura, List<DetalleFactura> detalles)
        {
            bool inserto = false;
            int idFactura = 0;

            try
            {
                StringBuilder sqlFactura = new StringBuilder();

                sqlFactura.Append("INSERT INTO factura (Fecha, IdentidadCliente, CodigoUsuario, ISV, Descuento, SubTotal, Total) VALUES (@Fecha, @IdentidadCliente, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total); ");
                sqlFactura.Append("SELECT LAST_INSERT_ID(); ");


                StringBuilder sqlDetalle = new StringBuilder();

                sqlDetalle.Append("INSERT INTO detallefactura (IdFactura, CodigoProducto, Precio, Cantidad, Total) VALUES (@IdFactura, @CodigoProducto, @Precio, @Cantidad, @Total); ");


                StringBuilder sqlExistencia = new StringBuilder();

                sqlExistencia.Append("UPDATE producto SET Existencia = Existencia - @Cantidad WHERE Codigo = @Codigo; ");


                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();

                    MySqlTransaction transaccion = _conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using (MySqlCommand _comando1 = new MySqlCommand(sqlFactura.ToString(), _conexion, transaccion))
                        {
                            _comando1.CommandType = System.Data.CommandType.Text;
                            _comando1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = factura.Fecha;
                            _comando1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = factura.IdentidadCliente;
                            _comando1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = factura.CodigoUsuario;
                            _comando1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = factura.ISV;
                            _comando1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = factura.Descuento;
                            _comando1.Parameters.Add("@SubTotal", MySqlDbType.Decimal).Value = factura.SubTotal;
                            _comando1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = factura.Total;
                            idFactura = Convert.ToInt32(_comando1.ExecuteScalar());

                        }

                        foreach (DetalleFactura detalle in detalles)
                        {
                            using (MySqlCommand _comando2 = new MySqlCommand(sqlDetalle.ToString(), _conexion, transaccion))
                            {
                                _comando2.CommandType = System.Data.CommandType.Text;
                                _comando2.Parameters.Add("@IdFactura", MySqlDbType.Int32).Value = idFactura;
                                _comando2.Parameters.Add("@CodigoProducto", MySqlDbType.VarChar, 80).Value = detalle.CodigoProducto;
                                _comando2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalle.Precio;
                                _comando2.Parameters.Add("@Cantidad", MySqlDbType.Decimal).Value = detalle.Cantidad;
                                _comando2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = detalle.Total;
                                _comando2.ExecuteNonQuery();
                            }

                            using (MySqlCommand _comando3 = new MySqlCommand(sqlExistencia.ToString(), _conexion, transaccion))
                            {
                                _comando3.CommandType = System.Data.CommandType.Text;
                                _comando3.Parameters.Add("@Cantidad", MySqlDbType.Decimal).Value = detalle.Cantidad;
                                _comando3.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = detalle.CodigoProducto;
                                _comando3.ExecuteNonQuery();

                            }

                        }

                        transaccion.Commit();

                        inserto = true;

                    }
                    catch (Exception)
                    {
                        inserto = false;
                        transaccion.Rollback();

                    }
                }
            }
            catch (System.Exception)
            {
            }

            return inserto;

        }
    }
}
