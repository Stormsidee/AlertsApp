using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlertsApp.Data
{
    public class AlertsList
    {
        //Ссылки
        public string url = "https://stw-planner.com/";

        //Списки
        public List<string> vbucks = new List<string>();
        public List<string> power = new List<string>();
        public List<string> mission = new List<string>();
        //Поля
        public string GetVb { get; set; }
        

        public void GetList()
        {

            for (var i = 0; i < vbucks.Count; i++)
            {
                bool Stonewood = Regex.IsMatch(mission[i], "\\bStonewood\\b");
                bool Plankerton = Regex.IsMatch(mission[i], "\\bPlankerton\\b");
                bool CannyValley = Regex.IsMatch(mission[i], "\\bCanny Valley\\b");
                bool TwinePeaks = Regex.IsMatch(mission[i], "\\bTwine Peaks\\b");
                bool EliminateandCollect = Regex.IsMatch(mission[i], "\\bEliminate and Collect\\b");
                bool RidetheLightning = Regex.IsMatch(mission[i], "\\bRide the Lightning\\b");
                bool RescuetheSurvivors = Regex.IsMatch(mission[i], "\\bRescue the Survivors\\b");
                bool DestroytheEncampments = Regex.IsMatch(mission[i], "\\bDestroy the Encampments\\b");
                bool Resupply = Regex.IsMatch(mission[i], "\\bResupply\\b");
                bool RetrievetheData = Regex.IsMatch(mission[i], "\\bRetrieve the Data\\b");
                bool BuildtheRadar = Regex.IsMatch(mission[i], "\\bBuild the Radar\\b");
                bool Category1FighttheStorm = Regex.IsMatch(mission[i], "\\bCategory 1 Fight the Storm\\b");
                bool RepairtheShelter = Regex.IsMatch(mission[i], "\\bRepair the Shelter\\b");
                bool Category2FighttheStorm = Regex.IsMatch(mission[i], "\\bCategory 2 Fight the Storm\\b");
                bool DelivertheBomb = Regex.IsMatch(mission[i], "\\bDeliver the Bomb\\b");
                bool EvacuatetheShelter = Regex.IsMatch(mission[i], "\\bEvacuate the Shelter\\b");
                bool RepairtheShelterGroup = Regex.IsMatch(mission[i], "\\bRepair the Shelter Group\\b");
                bool Category3FighttheStorm = Regex.IsMatch(mission[i], "\\bCategory 3 Fight the Storm\\b");
                bool Category4FighttheStorm = Regex.IsMatch(mission[i], "\\bCategory 4 Fight the Storm\\b");


                if (Stonewood == true)
                {
                    mission[i] = "Камнелесье\n";
                }
                if (Plankerton == true)
                {
                    mission[i] = "Планкертон\n";
                }
                if (CannyValley == true)
                {
                    mission[i] = "Вещая Долина\n";
                }
                if (TwinePeaks == true)
                {
                    mission[i] = "Линч Пикс\n";
                }
                if (EliminateandCollect == true)
                {
                    var t = "Убить и собрать\n";
                    mission[i] += t;
                }
                if (RidetheLightning == true)
                {
                    var c = "Запуск фургона\n";
                    mission[i] += c;
                }
                if (RescuetheSurvivors == true)
                {
                    var d = "Спасите выживших\n";
                    mission[i] += d;
                }
                if (DestroytheEncampments == true)
                {
                    var v = "Уничтожение порталов\n";
                    mission[i] += v;
                }
                if (Resupply == true)
                {
                    var b = "Пополнение запасов\n";
                    mission[i] += b;
                }
                if (RetrievetheData == true)
                {
                    var xz = "Извлечь данные\n";
                    mission[i] += xz;
                }
                if (BuildtheRadar == true)
                {
                    var dd = "Построить радарную сеть\n";
                    mission[i] += dd;
                }
                if (Category1FighttheStorm == true)
                {
                    var ee = "Категория 1: Битва с бурей\n";
                    mission[i] += ee;
                }
                if (RepairtheShelter == true)
                {
                    var ff = "Ремонт убежища\n";
                    mission[i] += ff;
                }
                if (Category2FighttheStorm == true)
                {
                    var bb = "Категория 2: Битва с бурей\n";
                    mission[i] += bb;
                }
                if (DelivertheBomb == true)
                {
                    var gg = "Доставка бомбы\n";
                    mission[i] += gg;
                }
                if (EvacuatetheShelter == true)
                {
                    var hh = "Эвакуация убежища\n";
                    mission[i] += hh;
                }
                if (RepairtheShelterGroup == true)
                {
                    var tr = "Ремонт убежища группа\n";
                    mission[i] += tr;
                }
                if (Category3FighttheStorm == true)
                {
                    var bg = "Категория 3:Битва с бурей\n";
                    mission[i] += bg;
                }
                if (Category4FighttheStorm == true)
                {
                    var er = "Категория 4: Битва с бурей\n";
                    mission[i] += er;
                }

                GetVb += "Вбаксы: " + vbucks[i] + "\n" + "Мощь: " + power[i] +"\n"+mission[i]+ "\n";


            }


        }
        
    }
}

