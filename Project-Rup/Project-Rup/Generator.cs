using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Rup
{
    class Generator
    {
        int fromCrit, toCrit, windowCrit;
        public Generator(int fromCritConstr, int toCritConstr, int windowCritConstr)
        {
            fromCrit = fromCritConstr;
            toCrit = toCritConstr;
            windowCrit = windowCritConstr;
            int teacherIdPom, prefPom, x, y,pom=0;
            int[,] noGrid = new int[2, 6];
            for (int i = 0; i < DataKeeper.Subjects.Count; i++)
            {
                (teacherIdPom, prefPom, x, y) = CheckLoPref(i, 1, noGrid);
                noGrid[x, y] = teacherIdPom;
                if (prefPom!=1||teacherIdPom==0)
                {
                    pom++;
                }
            }
            if(pom==0)
            {
                DataKeeper.Plan = noGrid;
            }
            else
            {
                pom = 0;
                noGrid = new int[2, 6];
                for (int j = 0; j < DataKeeper.Subjects.Count; j++)
                {
                    pom = 0;
                    noGrid = new int[2, 6];
                    (teacherIdPom, prefPom, x, y) = CheckLoPref(j, 2, noGrid);
                    noGrid[x, y] = teacherIdPom;
                    if (prefPom != 2 || teacherIdPom == 0)
                    {
                        pom++;
                    }
                    if(pom==0)
                    {
                        for (int i = 0; i < DataKeeper.Subjects.Count; i++)
                        {
                            if (i != j)
                            {
                                (teacherIdPom, prefPom, x, y) = CheckLoPref(i, 1, noGrid);
                                noGrid[x, y] = teacherIdPom;
                                if (prefPom != 1 || teacherIdPom == 0)
                                {
                                    pom++;
                                }
                            }
                        }
                        if (pom == 0)
                        {
                            DataKeeper.Plan = noGrid;
                            break;
                        }
                    }

                }
            }
        }

        private (int, int, int, int) CheckLoPref(int subjNumb, int prefValue, int[,] noGreed)
        {
            int teacherId = 0, lowPom = 111, iterPom, x = 0, y = 0, prefPom=0;
            for (int i = 0; i < 6; i++)
            {
                iterPom = DataKeeper.Subjects[subjNumb].Grid[0, i];
                if (iterPom != 0)
                {
                    if (noGreed[x,i] == 0)
                    {
                        prefPom = DataKeeper.Teachers.Where(k => k.Id == iterPom).FirstOrDefault().Pref;
                        if(i<fromCrit||i>toCrit)
                        {
                            prefPom += 30;
                        }
                        if (prefPom < lowPom)
                        {
                            teacherId = iterPom;
                            lowPom = prefPom;
                            y = i;
                            if (lowPom == prefValue)
                            {
                                return (teacherId, lowPom, x, y);
                            }
                        }
                    }
                }
            }
            if (lowPom != prefValue)
            {
                for (int i = 0; i < 6; i++)
                {
                    iterPom = DataKeeper.Subjects[subjNumb].Grid[1, i];
                    if (iterPom != 0)
                    {
                        if (noGreed[x, i] == 0)
                        {
                            prefPom = DataKeeper.Teachers.Where(k => k.Id == iterPom).FirstOrDefault().Pref;
                            if (i < fromCrit || i > toCrit)
                            {
                                prefPom += 30;
                            }
                            if (prefPom < lowPom)
                            {
                                teacherId = iterPom;
                                lowPom = prefPom;
                                x = 1;
                                y = i;
                                if (lowPom == prefValue)
                                {
                                    return (teacherId, lowPom, x, y);
                                }
                            }
                        }
                    }
                }
            }
            return (teacherId, lowPom, x, y);
        }

    }
}
