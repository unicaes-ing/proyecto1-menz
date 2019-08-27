using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquina
{
    public class modo_compra
    {

        public static int pago, bebida, Cbebida, can_mone_10=0, can_mone_05=0, can_mone_25=0,can_mone_100=0, can_billete_5=0, can_billete_1=0,
             //sumatoria de todas las bebidas
            total_bebida = cocacola + Mnaranja + Muva + pepsi + agua +
             petit +
             delvalle +
             coca0;
        public static decimal diemaqui, restante, baninterno=25.50m, totaldinero,retiro, cambio, totalmonedas, moneda, billete, Tcanc, C1 = 0.65m, C2 = 0.60m, C3 = 0.60m, C4 = 0.60m, C5 = 0.50m, C6 = 0.60m, C7 = 0.65m, C8 = 0.50m;
        public static int cocacola = 15, Mnaranja = 14, Muva = 14, pepsi = 15, agua = 14,
            petit = 14,
            delvalle = 14,
            coca0 = 14;
        bool repetir = true;
        animacion anima = new animacion();
        modo_administrador modad = new modo_administrador();
        estilo_maquina esma = new estilo_maquina();

        #region modocompra
        public void modcompra()
        {
            modo_compra mc/*mc= modo compra*/ = new modo_compra();
        regreso:

            Console.Clear();
            esma.estilo();

            Console.SetCursorPosition(9, 6);
            Console.WriteLine("Esta en modo compra ");
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("Realizar un pedido....??");
            Console.SetCursorPosition(9, 8);
            Console.WriteLine("1-)Si");
            Console.SetCursorPosition(9, 9);
            Console.WriteLine("2-)No");
            Console.SetCursorPosition(9, 10);
            Console.Write(":");
            int pedido = Convert.ToInt32(Console.ReadLine());
            if (pedido == 1)
            {
                Console.Clear();
                esma.estilo();
                Console.SetCursorPosition(9, 5);
                Console.WriteLine("Sabores de bebida");
                Console.SetCursorPosition(9, 6);
                Console.WriteLine("al lado de la maquina");
                Console.SetCursorPosition(9, 7);
                mc.venta();
            }
            else
                if (pedido == 2)
            {
                Console.SetCursorPosition(9, 11);
                Console.WriteLine("Presione <enter> para continuar");

            }
            else
            {
                Console.SetCursorPosition(9, 14);
                Console.WriteLine("Ingrese una de las opciones solicitadas");
                Console.ReadKey();
                goto regreso;
            }

            Console.SetCursorPosition(9, 16);
            Console.ReadKey();
        }
        #endregion

        //clase del modo venta contador de dinero y descontar bebidas
        #region venta
        public void venta()
        {
            Console.Clear();
            esma.estilo();
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("Cual bebida desea??");
            Console.SetCursorPosition(9, 7);
            int bebida = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(9, 8);
            do {
                Console.WriteLine("Cuantas Desea??");
                Console.SetCursorPosition(9, 9);
                if (int.TryParse(Console.ReadLine(), out Cbebida))
                {
                    switch (bebida)
                    {
                        case 1:
                            cocacola = cocacola - Cbebida;
                            Tcanc = C1 * Cbebida;
                            break;
                        case 2:
                            Mnaranja = Mnaranja - Cbebida;
                            Tcanc = C2 * Cbebida;
                            break;
                        case 3:
                            Muva = Muva - Cbebida;
                            Tcanc = C3 * Cbebida;
                            break;
                        case 4:
                            pepsi = pepsi - Cbebida;
                            Tcanc = C4 * Cbebida;
                            break;
                        case 5:
                            petit = petit - Cbebida;
                            Tcanc = C5 * Cbebida;

                            break;
                        case 6:
                            delvalle = delvalle - Cbebida;
                            Tcanc = C6 * Cbebida;

                            break;
                        case 7:
                            coca0 = coca0 - Cbebida;
                            Tcanc = C7 * Cbebida;

                            break;
                        case 8:
                            agua = agua - Cbebida;
                            Tcanc = C8 * Cbebida;
                            break;

                        default:
                            Console.WriteLine("Numero ingresado fuera de rango");
                            Console.ReadKey();
                            break;
                            
                    }
                    repetir = false;
                }
                
                else {
                      Console.Clear();
                      esma.estilo();
                    Console.SetCursorPosition(9,6);
                      Console.WriteLine("Debe de ingresar un numero entero");
                     }
            } while (repetir);
            Console.SetCursorPosition(9, 11);
            Console.WriteLine("Ha solicitado {0} unidades de la bebida N°{1} ", Cbebida, bebida);
            Console.SetCursorPosition(9, 12);
            Console.WriteLine("El total a cancelar es: {0:C2}", Tcanc);
            Console.SetCursorPosition(9, 14);
            Console.WriteLine("presione cualquier tecla para continuar");
            Console.SetCursorPosition(9, 16);
            Console.ReadKey();
            Console.Clear();
            esma.estilo();
            Console.SetCursorPosition(9, 6);
        repetir:
            Console.WriteLine("El pago será en:");
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("1-billete    2-moneda");
            Console.SetCursorPosition(9, 8);
            pago = Convert.ToInt32(Console.ReadLine());
            switch (pago)
            {
                case 1:
                    Console.SetCursorPosition(9, 11);
                    Console.WriteLine("Ingrese billete entre $5.00 y $1.00");
                regreso:
                    Console.SetCursorPosition(56, 20);
                    billete = Convert.ToDecimal(Console.ReadLine());
                    if (billete == 5.00m || billete == 1.00m)

                    {
                        if (Tcanc > billete)
                        {
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 8);
                            Console.WriteLine("Dinero Insuficiente");
                            Console.SetCursorPosition(9, 10);
                            Console.WriteLine("Ingrese mas dinero");
                            restante = Tcanc - billete;
                            Console.SetCursorPosition(9, 13);
                            Console.WriteLine("Restante: " + restante);
                            Console.ReadKey();
                            goto regreso;
                        }
                        else
                        {
                            cambio = billete - Tcanc;
                            Console.SetCursorPosition(9, 14);
                            Console.WriteLine("Su cambio es de :" + cambio);
                        }
                    }
                    if (billete == 5.00m)
                    {
                        can_billete_5 = can_billete_5 + 1;
                    }
                    else
                    {
                        can_billete_1 = can_billete_1 + 1;
                    }

                    break;

                case 2:
                pedir:
                    Console.SetCursorPosition(9, 10);
                    Console.WriteLine("Ingrese monedas en los valores de ...");
                    Console.SetCursorPosition(9, 11);
                    Console.WriteLine("0.05 |0.10 |0.25|1.00");
                    
                    do
                    {

                        Console.SetCursorPosition(56, 20);
                        moneda = Convert.ToDecimal(Console.ReadLine());
                       
                        if (moneda == 0.10m)
                        {
                            can_mone_10 = can_mone_10 + 1;
                        }
                        else
                        if (moneda == 0.05m)
                                { can_mone_05 = can_mone_05 + 1; }
                                else
                                 if (moneda == 0.25m)
                                { can_mone_25 = can_mone_25 + 1; }
                                else
                                  if (moneda == 1.00m)
                                { can_mone_100 = can_mone_100 + 1; }


                        if (moneda == 0.10m || moneda == 0.25m || moneda == 0.05m || moneda == 1.00m)
                        {
                            totalmonedas = totalmonedas + moneda;
                            Console.SetCursorPosition(9, 12);
                            Console.Write("Monedas insertadas= $" + totalmonedas);
                            restante = Tcanc - totalmonedas;
                          
                            if (restante > 0)
                            {
                                
                                Console.SetCursorPosition(9, 13);
                                Console.WriteLine("Restante: " + restante);
                            }
                            else
                            {
                                restante = 0.00m;
                                Console.SetCursorPosition(9, 13);
                                Console.WriteLine("Restante: " + restante);
                            }
                        } else
                            {
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9,5);
                                Console.WriteLine("Ingrese los valores solicitados");
                                Console.ReadKey();
                                goto pedir;
                            }

                    } while (Tcanc > totalmonedas);
                    Console.SetCursorPosition(9,14);
                    Console.WriteLine("Total dinero ingresado: "+totalmonedas);
                   
                    if (totalmonedas > Tcanc)
                    {
                        cambio = totalmonedas - Tcanc;
                        Console.SetCursorPosition(9,15);
                        Console.WriteLine("Su cambio es de :" + cambio);
                    }
                    Console.SetCursorPosition(9, 18);
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    esma.estilo();
                    Console.SetCursorPosition(9,10);
                    Console.WriteLine("Ingrese una opcion valida");
                    goto repetir;
            }
            totaldinero = (totalmonedas + billete) - cambio;
            Console.SetCursorPosition(9, 18);
            Console.ReadKey();

        }
        #endregion

        #region conbebi
        //clase para el detalle de maquina de la cantidad de sodas disponibles
        public void conbebi()
        {
            Console.Clear();
            esma.estilo();
            DateTime fecha = DateTime.Now;
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("Bebida           Disponibles");
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("Coca-cola           " + cocacola);
            Console.SetCursorPosition(9, 8);
            Console.WriteLine("Pepsi               " + pepsi);
            Console.SetCursorPosition(9, 9);
            Console.WriteLine("Mirinda Naranja     " + Mnaranja);
            Console.SetCursorPosition(9, 10);
            Console.WriteLine("Mirinda Uva         " + Muva);
            Console.SetCursorPosition(9, 11);
            Console.WriteLine("Jugos Petit         " + petit);
            Console.SetCursorPosition(9, 12);
            Console.WriteLine("Jugo del valle      " + delvalle);
            Console.SetCursorPosition(9, 13);
            Console.WriteLine("Coca-Cola 0         "+coca0);
            Console.SetCursorPosition(9, 14);
            Console.WriteLine("Agua                " + agua);
            total_bebida = cocacola + petit + pepsi + Mnaranja + Muva + delvalle + agua;
            Console.SetCursorPosition(9, 15);
            Console.WriteLine("Total bebidas: " + total_bebida);
            Console.SetCursorPosition(9, 16);
            Console.ReadKey();
        }
        #endregion

        #region monedas
        public void con_monedas()
        {
            Console.Clear();
            esma.estilo();
            DateTime fecha = DateTime.Now;
            Console.SetCursorPosition(9,6);
            Console.WriteLine(fecha);
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("Cantidad de billetes y monedas ingresadas");
            Console.SetCursorPosition(9, 8);
            Console.WriteLine("modenas 0.05:" + can_mone_05);
            Console.SetCursorPosition(9, 9);
            Console.WriteLine("monedas 0.10: " + can_mone_10);
            Console.SetCursorPosition(9, 10);
            Console.WriteLine("monedas 0.25: "+can_mone_25);
            Console.SetCursorPosition(9, 11);
            Console.WriteLine("monedas 1.00: "+can_mone_100);
            Console.SetCursorPosition(9, 12);
            Console.WriteLine("Billetes de $1.00: "+can_billete_1);
            Console.SetCursorPosition(9, 13);
            Console.WriteLine("Billetes de $5.00: "+can_billete_5);
            Console.SetCursorPosition(9, 14);
            Console.WriteLine("Total dinero: " + totaldinero.ToString("C2"));
            diemaqui = totaldinero + baninterno;
            Console.SetCursorPosition(9,15);
            Console.WriteLine("Total dinero en maquina: " + diemaqui.ToString("C2"));
            Console.SetCursorPosition(9, 16);
            Console.ReadKey();

        }
        #endregion

        #region vaciar
        public void vaciar_banco()
        {
            modo_compra mc/*mc= modo compra*/ = new modo_compra();
            int op;
            do
            {
                Console.SetCursorPosition(9,6);
                Console.WriteLine("1-)Retirar dinero ");
                Console.SetCursorPosition(9, 7);
                Console.WriteLine("2-)Restablecer valores a 0 ");
                Console.SetCursorPosition(9, 8);
                Console.WriteLine("3-)Salir ");
                Console.SetCursorPosition(9, 9);
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                    pedirdenuevo:
                        Console.WriteLine("Ingrrese cantidad a retirar");
                        retiro = Convert.ToDecimal(Console.ReadLine());
                        if (retiro > baninterno)
                        {
                            Console.WriteLine("La cantidad de retiro supera a la cantidad interna");
                            goto pedirdenuevo;
                        }
                        else
                        {
                            baninterno = baninterno - retiro;
                            Console.WriteLine("Quedan: " + baninterno.ToString("C2"));
                        }
                        Console.SetCursorPosition(9, 16);
                        Console.ReadKey();

                        break;
                    case 2:
                        regreso:
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 7);
                        Console.WriteLine("Estas seguro de vaciar los valores??");
                        Console.SetCursorPosition(9, 8);
                        Console.WriteLine("1-)Si ");
                         Console.SetCursorPosition(9, 9);
                        Console.WriteLine("2-)No ");
                        Console.SetCursorPosition(9, 10);
                        Console.Write("opcion:  ");
                        int dec = Convert.ToInt32(Console.ReadLine());
                        if (dec == 1)
                        {
                            Console.Clear();
                            esma.estilo();


                            can_mone_10 = 0;
                            can_mone_05 = 0;
                            can_mone_25 = 0;
                            can_mone_100 = 0;
                            can_billete_1 = 0;
                            can_billete_5 = 0;
                            totaldinero = 0;
                            Console.SetCursorPosition(9, 7);
                            Console.WriteLine("los valores han sido restablecidos");
                            mc.con_monedas();
                        }
                        else
                        if (dec == 2)
                        {
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 10);
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.SetCursorPosition(9, 16);
                            Console.ReadKey();
                        }
                        else
                        { Console.WriteLine("Ingrese opcion valida");
                            goto regreso;
                        }

                        break;
                    case 3:
                        break;
                    default:
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 10);
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.SetCursorPosition(9, 16);
                        Console.ReadKey();
                        break;
                }
            } while (op != 3);

        }
        #endregion

        #region cambiopreciobebida

        public void precio_bebida()
        {
            
            int op;
            do
            {
                Console.Clear();
                esma.estilo();
                Console.SetCursorPosition(9, 6);
                Console.WriteLine("Desea cambiar los precios de bebida??");
                Console.SetCursorPosition(9, 8);
                Console.WriteLine("1-)Si ");
                Console.SetCursorPosition(9, 9);
                Console.WriteLine("2-)No ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                   
                    case 1:
                       
                        esma.estilo();
                        Console.SetCursorPosition(9,6);
                        Console.WriteLine("CAmbiar precio para...");
                        Console.SetCursorPosition(9,8);
                        Console.WriteLine("Coca-cola");
                        Console.SetCursorPosition(9, 9);
                        C1 = Convert.ToDecimal(Console.ReadLine());
                        Console.SetCursorPosition(9, 10);
                        Console.WriteLine("Pepsi");
                        Console.SetCursorPosition(9, 11);
                        C2 = Convert.ToDecimal(Console.ReadLine());
                        Console.SetCursorPosition(9, 12);
                        Console.WriteLine("Mirinda Naranja");
                        Console.SetCursorPosition(9, 13);
                        C3 = Convert.ToDecimal(Console.ReadLine());
                        Console.SetCursorPosition(9, 14);
                        Console.WriteLine("Mirinda Uva");
                        Console.SetCursorPosition(9, 15);
                        C4 = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 6);
                        Console.WriteLine("CAmbiar precio para...");
                        Console.SetCursorPosition(9, 8);
                        Console.WriteLine("Jugos Petit");
                        Console.SetCursorPosition(9, 9);
                        C5 = Convert.ToDecimal(Console.ReadLine());
                        Console.SetCursorPosition(9, 10);
                        Console.WriteLine("Jugo del valle");
                        Console.SetCursorPosition(9, 11);
                        C6 = Convert.ToDecimal(Console.ReadLine());
                        Console.SetCursorPosition(9, 12);
                        Console.WriteLine("Coca-Cola 0");
                        Console.SetCursorPosition(9, 13);
                        C7 = Convert.ToDecimal(Console.ReadLine());
                        Console.SetCursorPosition(9, 14);
                        Console.WriteLine("Agua");
                        Console.SetCursorPosition(9, 15);
                        C8 = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9,10);
                        Console.WriteLine("Valores cambiados con exito");
                        Console.SetCursorPosition(9, 16);
                        Console.ReadKey();
                      
                        modad.modadmin();
                        break;

                    case 2:
                        
                        modad.modadmin();
                        break;
                    default:
                        Console.SetCursorPosition(9, 14);
                        Console.WriteLine("Ingres una opcion valida");
                        Console.SetCursorPosition(9, 16);
                        Console.ReadKey();
                        break;


                }
            } while (op != 2);
        }

        #endregion

        #region cambiodecanbebidas

        public void cambio_canti()
        {
            
            int op;
            do
            {
                Console.Clear();
                esma.estilo();
                Console.SetCursorPosition(9, 6);
                Console.WriteLine("Desea cambiar las cantidades de bebida??");
                Console.SetCursorPosition(9, 8);
                Console.WriteLine("1-)Si ");
                Console.SetCursorPosition(9, 9);
                Console.WriteLine("2-)No ");
                Console.SetCursorPosition(9, 10);
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        pedir:
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 6);
                        Console.WriteLine("CAmbiar cantida para...");
                        Console.SetCursorPosition(9, 8);
                        Console.WriteLine("Coca-cola");
                        Console.SetCursorPosition(9, 9);
                        cocacola = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(9, 10);
                        Console.WriteLine("Pepsi");
                        Console.SetCursorPosition(9, 11);
                        pepsi = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(9, 12);
                        Console.WriteLine("Mirinda Naranja");
                        Console.SetCursorPosition(9, 13);
                        Mnaranja = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(9, 14);
                        Console.WriteLine("Mirinda Uva");
                        Console.SetCursorPosition(9, 15);
                        Muva = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 6);
                        Console.WriteLine("CAmbiar cantida para...");
                        Console.SetCursorPosition(9, 7);
                        Console.WriteLine("Jugos Petit");
                        Console.SetCursorPosition(9, 8);
                        petit = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(9, 9);
                        Console.WriteLine("Jugo del valle");
                        Console.SetCursorPosition(9, 10);
                        delvalle = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(9, 11);
                        Console.WriteLine("Coca-Cola 0");
                        Console.SetCursorPosition(9, 12);
                        coca0 = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(9, 13);
                        Console.WriteLine("Agua");
                        Console.SetCursorPosition(9, 14);
                        agua = Convert.ToInt32(Console.ReadLine());
                        if (total_bebida > 100)
                        {
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 6);
                            Console.WriteLine("Se ha excedido del limite de bebidas");
                            Console.SetCursorPosition(9, 9);
                            Console.WriteLine("Ingrese cantidades que en total sean 100");
                            Console.SetCursorPosition(9, 16);
                            Console.ReadKey();
                            goto pedir;
                        }
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 10);
                        Console.WriteLine("Cambios realizados con exito");
                        Console.SetCursorPosition(9, 16);
                        Console.ReadKey();
                            modad.modadmin();
                        
                        break;

                    case 2:
                        modad.modadmin();
                        break;
                    default:
                        Console.WriteLine("Ingres una opcion valida");
                        Console.SetCursorPosition(9, 16);
                        Console.ReadKey();
                        break;


                }
            } while (op != 2);

        }

        #endregion
    }


}


