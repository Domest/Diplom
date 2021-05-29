using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            IEnumerable<CargoObject> GetObj = null;
            List<CargoObject> LObj = new List<CargoObject>();
            List<Service> SObj = new List<Service>();
            IEnumerable<Request> GetReq;
            
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
                        Name = "Выгрузка груженого контейнера с платформы и перемещение к месту растарки (на расстояние до 100 м) (медь, цинк, свинец, бумага, картон,   целлюлоза)",
                        Posibility = "3",
                        MeasureType = "контейнер",
                        RubPrice = 3238.95f,
                        UsdPrice = 42.9f
                    }
                };
                GetServ = get1;
                SObj = get1.ToList();
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
                LObj = get2.ToList();

                foreach (CargoObject co in GetObj)
                {
                    co.PossibleServices = new List<Service>();
                    foreach (Service sr in GetServ)
                    {
                        char[] pars = sr.Posibility.ToCharArray();
                        for (int i = 0; i < pars.Length; i++)
                        {

                            if (co.BackId == int.Parse(pars[i].ToString()))
                            {
                                co.PossibleServices.Add(sr);
                                sr.CargoObjects.Add(co);
                                break;
                            }
                        }


                        //    for (int i = 0; i < pars.Length - 1; i++)
                        //{
                        //    switch (pars[i])
                        //    {
                        //        case '1':
                        //            if (co.BackId == int.Parse(pars[i].ToString()))
                        //            {
                        //                co.PossibleServices.Add(sr);
                        //                sr.CargoObjects.Add(co);
                        //            }
                        //            break;
                        //        case '2':
                        //            if (co.BackId == int.Parse(pars[i].ToString()))
                        //            {
                        //                co.PossibleServices.Add(sr);
                        //                sr.CargoObjects.Add(co);
                        //            }
                        //            break;
                        //        case '3':
                        //            if (co.BackId == int.Parse(pars[i].ToString()))
                        //            {
                        //                co.PossibleServices.Add(sr);
                        //                sr.CargoObjects.Add(co);
                        //            }
                        //            break;
                        //        case '4':
                        //            if (co.BackId == int.Parse(pars[i].ToString()))
                        //            {
                        //                co.PossibleServices.Add(sr);
                        //                sr.CargoObjects.Add(co);
                        //            }
                        //            break;
                        //        case '5':
                        //            if (co.BackId == int.Parse(pars[i].ToString()))
                        //            {
                        //                co.PossibleServices.Add(sr);
                        //                sr.CargoObjects.Add(co);
                        //            }
                        //            break;
                        //    }
                        //}
                    }
                }
                context.DBCargo.AddRange(GetObj);
                
            }
            if (!context.DBRequests.Any())
            {
                
                Collection<CargoObject> test1 = new Collection<CargoObject>();
                test1.Add(LObj[0]);
                Collection<Service> test2 = new Collection<Service>();
                test2.Add(SObj[0]);
                var get3 = new Request[]
                {
                    new Request
                    {
                        CargoObj = test1,
                        Services = test2,
                        User = "user123",
                        Status = "ожидает",
                        CargoAmount = 15,
                        TotalSumRub = 50000,
                        TotalSumUsd = 500
                    }
                };
                LObj[0].Reqs.Add(get3[0]);
                SObj[0].Reqs.Add(get3[0]);
                GetReq = get3;
                context.DBRequests.AddRange(GetReq);
                context.SaveChanges();
            }
        }
    }
}
