using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diplom1.Models;

namespace Diplom1.Data
{
    public class BaseData
    {
        public static void Initial(AppDbContextData context)
        {
            IEnumerable<Service> GetServ = null;
            IEnumerable<CargoObject> GetObj;
            
            if (!context.DBServices.Any())
            {
                var get1 = new Service[]
                {
                    new Service
                    {
                        Name = "Дополнительные работы при выгрузке, с нарушением укладки груза в вагоне",
                        Posibility = "12345",
                        MeasureType = "тонн",
                        RubPrice = 755f,
                        UsdPrice = 10f
                    },
                    new Service
                    {
                        Name = "Рассортировка грузов металлопродукции",
                        Posibility = "1",
                        MeasureType = "тонн",
                        RubPrice = 166.1f,
                        UsdPrice = 2.2f
                    },
                    new Service
                    {
                        Name = "Рассортировка грузов по параметрам без снятия спецификации",
                        Posibility = "12345",
                        MeasureType = "тонн",
                        RubPrice = 604f,
                        UsdPrice = 8f
                    },
                    new Service
                    {
                        Name = "Перемещение черных, цветных металлов, оборудования и других грузов между пирсами в границах порта",
                        Posibility = "12345",
                        MeasureType = "тонн",
                        RubPrice = 264.25f,
                        UsdPrice = 3.5f
                    },
                    new Service
                    {
                        Name = "Приведение бухт катанки в транспортабельное состояние, без стоимости материалов",
                        Posibility = "1",
                        MeasureType = "тонн",
                        RubPrice = 5285f,
                        UsdPrice = 70f
                    },
                    new Service
                    {
                        Name = "Приведение поврежденных рулонов бумаги, картона в транспортабельное состояние, без стоимости материалов",
                        Posibility = "5",
                        MeasureType = "рулон",
                        RubPrice = 755f,
                        UsdPrice = 10f
                    },
                    new Service
                    {
                        Name = "Приведение поврежденных рулонов бумаги, картона в транспортабельное состояние, без стоимости материалов",
                        Posibility = "5",
                        MeasureType = "рулон",
                        RubPrice = 755f,
                        UsdPrice = 10f
                    }
                };
                GetServ = get1;
                context.DBServices.AddRange(GetServ);
            }

            if (!context.DBCargo.Any())
            {
                var get2 = new CargoObject[]
                {
                    new CargoObject
                    {
                        BackId = 1,
                        Name = "Чёрные и цветные металлы",
                    },
                    new CargoObject
                    {
                        BackId = 2,
                        Name = "Рефрижераторные грузы"
                    },
                    new CargoObject
                    {
                        BackId = 3,
                        Name = "Контейнеры"
                    },
                    new CargoObject
                    {
                        BackId = 4,
                        Name = "Генеральный груз"
                    },
                    new CargoObject
                    {
                        BackId = 5,
                        Name = "Лесные грузы и целлюлоза"
                    }
                };
                GetObj = get2;

                foreach (CargoObject co in GetObj)
                {
                    co.PossibleServices = new List<Service>();
                    foreach (Service sr in GetServ)
                    {
                        char[] pars = sr.Posibility.ToCharArray();
                        for (int i = 0; i < pars.Length - 1; i++)
                        {
                            switch (pars[i])
                            {
                                case '1':
                                    if (co.ID == int.Parse(pars[i].ToString()))
                                        co.PossibleServices.Add(sr);
                                    break;
                                case '2':
                                    if (co.ID == int.Parse(pars[i].ToString()))
                                        co.PossibleServices.Add(sr);
                                    break;
                                case '3':
                                    if (co.ID == int.Parse(pars[i].ToString()))
                                        co.PossibleServices.Add(sr);
                                    break;
                                case '4':
                                    if (co.ID == int.Parse(pars[i].ToString()))
                                        co.PossibleServices.Add(sr);
                                    break;
                                case '5':
                                    if (co.ID == int.Parse(pars[i].ToString()))
                                        co.PossibleServices.Add(sr);
                                    break;
                            }
                        }
                    }
                }
                context.DBCargo.AddRange(get2);
                context.SaveChanges();
            }   
        }
    }
}
