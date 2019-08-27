using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquina
{
    class modo_administrador
    {
        estilo_maquina esma = new estilo_maquina();

        #region administrador 
        public void modadmin()
            {
               modo_administrador modad = new modo_administrador();
            estilo_maquina esma = new estilo_maquina();
            modo_compra mc/*mc= modo compra*/ = new modo_compra();
            int qdh;//qdh es la variable de la decision de que desea hacer 
                do
                {
                mostrar:
                
                    Console.Clear();
                    esma.estilo();
                    Console.SetCursorPosition(9, 6);
                    Console.WriteLine("Que desea hacer??");
                    Console.SetCursorPosition(9, 8);
                    Console.WriteLine("1-)Administrar Bebidas");
                    Console.SetCursorPosition(9, 9);
                    Console.WriteLine("2-)Banco de Monedas");
                    Console.SetCursorPosition(9, 10);
                    Console.WriteLine("3-)Banco de Billetes");
                    Console.SetCursorPosition(9, 11);
                    Console.WriteLine("4-)Detalle de Maquina");
                    Console.SetCursorPosition(9, 12);
                    Console.WriteLine("5-)Salir");
                    do
                    {
                        Console.SetCursorPosition(9, 15);
                        Console.Write(":");
                        qdh = Convert.ToInt32(Console.ReadLine());
                    switch (qdh)
                    {
                        case 1:
                            regreso:
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 5);
                            Console.WriteLine("Administracion de bebidas");
                            Console.SetCursorPosition(9, 6);
                            Console.WriteLine("1-)Cambiar precio de bebida");
                            Console.SetCursorPosition(9, 7);
                            Console.WriteLine("2-)Cambiar cantidad de bebida");
                            Console.SetCursorPosition(9, 8);
                            int op = Convert.ToInt32(Console.ReadLine());
                            if (op == 1)
                            {
                                mc.precio_bebida();
                            }
                            else
                            if (op==2) {
                                mc.cambio_canti();
                            }
                            else
                            {
                                Console.SetCursorPosition(9, 10);
                                Console.WriteLine("Ingrese una opcion valida");
                                Console.SetCursorPosition(9, 16);
                                Console.ReadKey();
                                goto regreso;
                            }
                                break;

                            case 2:
                                Console.Clear();
                                esma.estilo();
                                Console.SetCursorPosition(9, 5);
                                Console.WriteLine("Banco de Monedas");
                                mc.vaciar_banco();
                                break;
                            case 3:
                                Console.Clear();
                                esma.estilo();
                                Console.SetCursorPosition(9, 5);
                                Console.WriteLine("Banco de Billetes");
                            mc.vaciar_banco();
                            break;
                            case 4:
                                Console.Clear();
                                esma.estilo();
                                Console.SetCursorPosition(9, 5);
                                Console.WriteLine("Detalle de la Maquina");
                                modad.detalle_maquina();
                                break;
                            case 5:
                                break;
                            default:
                                Console.Clear();
                                esma.estilo();
                                Console.SetCursorPosition(9, 11);
                                Console.WriteLine("Elija una de las opciones solicitadas");
                            Console.SetCursorPosition(9, 16);
                            Console.ReadKey();
                                goto mostrar;
                        }
                    } while (qdh > 5 || qdh <= 0);
                } while (qdh != 5);
            }
        #endregion

        #region detmaquina
            public void detalle_maquina()
                {
                    modo_compra mc/*mc= modo compra*/ = new modo_compra();
            int deci;
            do
            {
            regreso:
                Console.Clear();
                esma.estilo();
                DateTime fecha = DateTime.Now;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine("fecha:" + fecha.ToString("dd-MM-yy hh:mm"));
                Console.SetCursorPosition(9, 6);
                Console.WriteLine("1-)Total de bebidas");
                Console.SetCursorPosition(9, 7);
                Console.WriteLine("2-)Total de dinero");
                Console.SetCursorPosition(9, 8);
                Console.WriteLine("3-)Salir ");
                Console.SetCursorPosition(9, 10);
                Console.Write("opcion: ");
                deci = Convert.ToInt32(Console.ReadLine());
                do
                {
                    switch (deci)
                    {
                        case 1:
                            mc.conbebi();
                            break;
                        case 2:
                            mc.con_monedas();
                            break;
                        case 3:
                            Console.SetCursorPosition(9, 12);
                            Console.WriteLine("presione aceptar para continuar");
                            modadmin();
                            break;
                        default:
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 10);
                            Console.WriteLine("ingrese una opcion valida");
                            Console.SetCursorPosition(9, 12);
                            Console.WriteLine("presione cualquier tecla para continuar");
                            Console.ReadKey();
                            goto regreso;
                    }
                } while (deci > 3 || deci<1);

            } while (deci != 3);
            }
        #endregion
    }
}
