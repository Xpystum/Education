using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Дом;

namespace Строительство_дома.Строители
{
    internal class Team //бригада строителей
    {
        public List<Worker> workers { get; set; } = new List<Worker>();
        
        
        public void StartBuildHouse(House house)
        {
            bool a = false;
            //костыли =)

                

            workers.Where(u => u.GetType() == typeof(TeamLeader)); //как можно найти только тимлидов (не проходя по всем листу)
                foreach (Worker worker in workers)
                {
                
                    if (!(worker is TeamLeader))
                    {
                        worker.jobs(house);

                    }
                    else
                    {
                        a = true;
                    }

                    if (!a && !house.CheckStatusBild)
                    {
                        foreach (Worker teamleader in workers)
                        {
                            if (teamleader is TeamLeader)
                            {
                                try
                                {
                                    TeamLeader? tm = teamleader as TeamLeader;
                                    if (tm.InfoBuild.ContainsKey(worker))
                                    {
                                        StringBuilder sb = new StringBuilder();
                                        sb = tm.InfoBuild[worker];
                                        sb.Append($"Строитель {worker._FIO} построил " + worker.element?.Name);
                                        //sb.AppendJoin("\n\t", $"Строитель {worker._FIO} построил " + worker.element?.Name);
                                        sb.AppendLine();
                                        tm.InfoBuild[worker] = sb;
                                    }
                                    else
                                    {
                                        if(tm != null)
                                        {
                                        StringBuilder sb = new StringBuilder();
                                        sb.AppendLine($"Строитель {worker._FIO} построил " + worker.element?.Name);
                                        tm.InfoBuild.Add(worker, sb);
                                        }
                                        else {throw new NullReferenceException("Null type");}
                                       
                                    }

                                }
                                catch (Exception)
                                {
                                    throw new NullReferenceException("TeamLeader был null");
                                }

                            }
                        }
                    }


                }

        }
    }
}
