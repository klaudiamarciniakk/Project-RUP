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
            if(pom==0 && CheckBreaks(noGrid) == 0)
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
                        if (pom == 0 && CheckBreaks(noGrid) == 0)
                        {
                            DataKeeper.Plan = noGrid;
                            break;
                        }
                    }
                }
                if(pom!=0)
                {
                    noGrid = GenerateAll();
                    DataKeeper.Plan = noGrid;
                }
            }
        }

        private int[,] GenerateAll()
        {
            List<List<int>> allPlans = new List<List<int>>();
            List<int> generatedPlan = new List<int>();
            int[,] noGrid = new int[2, 6];
            int[] iterSun = new int[DataKeeper.Subjects.Count];
            int[] iterSat = new int[DataKeeper.Subjects.Count];
            int prefSum = 0, pom = 0,pom2=0,pomX=0,pomY=0;
            for (int i = 0; i < DataKeeper.Subjects.Count; i++)
            {
                OneMore:
                if (iterSat[i] < 6)
                {
                    for (int j = iterSat[i]; j < 6; j++)
                    {
                        if(DataKeeper.Subjects[i].Grid[0,j]!=0&&noGrid[0,j]==0)
                        {
                            noGrid[0, j] = DataKeeper.Subjects[i].Grid[0, j];
                            generatedPlan.Add(noGrid[0, j]);
                            prefSum += DataKeeper.Teachers.Where(k => k.Id == noGrid[0, j]).FirstOrDefault().Pref;
                            if(j<fromCrit||j>toCrit)
                            {
                                prefSum += 30;
                            }
                            iterSat[i] = j + 1;
                            if(i!=DataKeeper.Subjects.Count-1)
                            {
                                i++;
                                goto OneMore;
                            }
                            break;
                        }
                        if(j==5)
                        {
                            iterSat[i] = 6;
                        }
                    }
                }
                if (iterSun[i] < 6 && iterSat[i] == 6)
                {
                    for (int j = iterSun[i]; j < 6; j++)
                    {
                        if (DataKeeper.Subjects[i].Grid[1, j] != 0 && noGrid[1, j] == 0)
                        {
                            noGrid[1, j] = DataKeeper.Subjects[i].Grid[1, j];
                            generatedPlan.Add(noGrid[1, j]);
                            prefSum += DataKeeper.Teachers.Where(k => k.Id == noGrid[1, j]).FirstOrDefault().Pref;
                            if (j < fromCrit || j > toCrit)
                            {
                                prefSum += 30;
                            }
                            iterSun[i] = j + 1;
                            if (i != DataKeeper.Subjects.Count - 1)
                            {
                                i++;
                                goto OneMore;
                            }
                            break;
                        }
                        if (j == 5)
                        {
                            if(i==0)
                            {
                                pom++;
                            }
                            iterSun[i] = 6;
                        }
                    }
                }
                if(pom!=0)
                {
                    break;
                }
                if(i==DataKeeper.Subjects.Count-1)
                {
                    pom2 = CheckBreaks(noGrid);
                    switch(windowCrit)
                    {
                        case 1:
                            if(pom2>1)
                            {
                                prefSum += (int)Math.Pow(2, pom2);
                            }
                            break;
                        case 2:
                            if (pom2 > 2)
                            {
                                prefSum += (int)Math.Pow(2, pom2);
                            }
                            break;
                        case 3:
                            if (pom2 > 3)
                            {
                                prefSum += (int)Math.Pow(2, pom2);
                            }
                            break;
                        case 4:
                            if (pom2 > 4)
                            {
                                prefSum += (int)Math.Pow(2, pom2);
                            }
                            break;
                        case 5:
                            if (pom2 > 5)
                            {
                                prefSum += (int)Math.Pow(2, pom2);
                            }
                            break;
                        case 6:
                            if (pom2 > 6)
                            {
                                prefSum += (int)Math.Pow(2, pom2);
                            }
                            break;
                        case 7:
                            prefSum += (int)Math.Pow(2, pom2);
                            break;
                    }
                    generatedPlan.Add(prefSum);
                    if(generatedPlan.Count!=DataKeeper.Subjects.Count+1)
                    {
                        goto forOut;
                    }
                    allPlans.Add(generatedPlan.ToList());
                    generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                    for (int j = 0; j < 6; j++)
                    {
                        if(noGrid[1,j]==generatedPlan.Last())
                        {
                            pomX = 1;
                            pomY = j;
                            break;
                        }
                        if (noGrid[0, j] == generatedPlan.Last())
                        {
                            pomX = 0;
                            pomY = j;
                            break;
                        }
                    }
                    pom2 = 0;
                    if(pomX==1)
                    {
                        for (int j = pomY+1; j < 6; j++)
                        {
                            if(DataKeeper.Subjects[i].Grid[1,j]!=0)
                            {
                                pom2++;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0 + 1; j < 6; j++)
                        {
                            if (DataKeeper.Subjects[i].Grid[1, j] != 0)
                            {
                                pom2++;
                            }
                        }
                        for (int j = pomY + 1; j < 6; j++)
                        {
                            if (DataKeeper.Subjects[i].Grid[0, j] != 0)
                            {
                                pom2++;
                            }
                        }
                    }
                    if(pom2==0)
                    {
                        allPlans.RemoveAt(allPlans.IndexOf(allPlans.Last()));
                        generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                        prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[pomX, pomY]).FirstOrDefault().Pref;
                        if (pomY < fromCrit || pomY > toCrit)
                        {
                            prefSum -= 30;
                        }
                        noGrid[pomX, pomY] = 0;
                        iterSat[i] = 0;
                        iterSun[i] = 0;
                        i--;
                        for (int j = 0; j < 6; j++)
                        {
                            if (noGrid[1, j] == generatedPlan.Last())
                            {
                                generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                                prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[1, j]).FirstOrDefault().Pref;
                                if (j < fromCrit || j > toCrit)
                                {
                                    prefSum -= 30;
                                }
                                noGrid[1, j] = 0;
                                iterSat[i] = 6;
                                iterSun[i] = j + 1;
                                break;
                            }
                            if (noGrid[0, j] == generatedPlan.Last())
                            {
                                generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                                prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[0, j]).FirstOrDefault().Pref;
                                if (j < fromCrit || j > toCrit)
                                {
                                    prefSum -= 30;
                                }
                                noGrid[0, j] = 0;
                                iterSat[i] = j + 1;
                                iterSun[i] = 0;
                                break;
                            }
                        }
                        i--;
                    }
                    else
                    {
                        generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                        prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[pomX, pomY]).FirstOrDefault().Pref;
                        if (pomY < fromCrit || pomY > toCrit)
                        {
                            prefSum -= 30;
                        }
                        noGrid[pomX, pomY] = 0;
                        if(pomX==1)
                        {
                            iterSun[i] = pomY + 1;
                            iterSat[i] = 6;
                            goto OneMore;
                        }
                        else
                        {
                            iterSat[i] = pomY + 1;
                            iterSun[i] = 0;
                            goto OneMore;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (noGrid[1, j] == generatedPlan.Last())
                        {
                            pomX = 1;
                            pomY = j;
                            break;
                        }
                        if (noGrid[0, j] == generatedPlan.Last())
                        {
                            pomX = 0;
                            pomY = j;
                            break;
                        }
                    }
                    pom2 = 0;
                    if (pomX == 1)
                    {
                        for (int j = pomY + 1; j < 6; j++)
                        {
                            if (DataKeeper.Subjects[i].Grid[1, j] != 0)
                            {
                                pom2++;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0 + 1; j < 6; j++)
                        {
                            if (DataKeeper.Subjects[i].Grid[1, j] != 0)
                            {
                                pom2++;
                            }
                        }
                        for (int j = pomY + 1; j < 6; j++)
                        {
                            if (DataKeeper.Subjects[i].Grid[0, j] != 0)
                            {
                                pom2++;
                            }
                        }
                    }
                    if (pom2 == 0)
                    {
                        generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                        prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[pomX, pomY]).FirstOrDefault().Pref;
                        if (pomY < fromCrit || pomY > toCrit)
                        {
                            prefSum -= 30;
                        }
                        noGrid[pomX, pomY] = 0;
                        iterSat[i] = 0;
                        iterSun[i] = 0;
                        i--;
                        for (int j = 0; j < 6; j++)
                        {
                            if (noGrid[1, j] == generatedPlan.Last())
                            {
                                generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                                prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[1, j]).FirstOrDefault().Pref;
                                if (j < fromCrit || j > toCrit)
                                {
                                    prefSum -= 30;
                                }
                                noGrid[1, j] = 0;
                                iterSat[i] = 6;
                                iterSun[i] = j + 1;
                                break;
                            }
                            if (noGrid[0, j] == generatedPlan.Last())
                            {
                                generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                                prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[0, j]).FirstOrDefault().Pref;
                                if (j < fromCrit || j > toCrit)
                                {
                                    prefSum -= 30;
                                }
                                noGrid[0, j] = 0;
                                iterSat[i] = j + 1;
                                iterSun[i] = 0;
                                break;
                            }
                        }
                        i--;
                    }
                    else
                    {
                        generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
                        prefSum -= DataKeeper.Teachers.Where(k => k.Id == noGrid[pomX, pomY]).FirstOrDefault().Pref;
                        if (pomY < fromCrit || pomY > toCrit)
                        {
                            prefSum -= 30;
                        }
                        noGrid[pomX, pomY] = 0;
                        if (pomX == 1)
                        {
                            iterSun[i] = pomY + 1;
                            iterSat[i] = 6;
                            goto OneMore;
                        }
                        else
                        {
                            iterSat[i] = pomY + 1;
                            iterSun[i] = 0;
                            goto OneMore;
                        }
                    }
                }
            }
        forOut:
            allPlans.RemoveAt(allPlans.IndexOf(allPlans.Last()));
            pom = allPlans[0].Last();
            generatedPlan = allPlans[0];
            for (int i = 1; i < allPlans.Count; i++)
            {
                if(pom>allPlans[i].Last())
                {
                    pom = allPlans[i].Last();
                    generatedPlan = allPlans[i];
                }
            }
            generatedPlan.RemoveAt(generatedPlan.IndexOf(generatedPlan.Last()));
            noGrid = new int[2, 6];
            for (int i = 0; i < generatedPlan.Count; i++)
            {
                for (int k = 0; k < DataKeeper.Subjects.Count; k++)
                {
                    int pom5 = 0;

                    for (int j = 0; j < 6; j++)
                    {
                        if (generatedPlan[i] == DataKeeper.Subjects[k].Grid[0, j]&&noGrid[0,j]==0)
                        {
                            noGrid[0, j] = generatedPlan[i];
                            pom5++;
                            break;
                        }
                        if (generatedPlan[i] == DataKeeper.Subjects[k].Grid[1, j] && noGrid[0, j] == 0)
                        {
                            noGrid[1, j] = generatedPlan[i];
                            pom5++;
                            break;
                        }

                    }
                    if(pom5!=0)
                    {
                        break;
                    }
                }
            }
            return noGrid;
        }

        private int CheckBreaks(int[,] noGrid)
        {
            if (windowCrit == 0)
            {
                return 0;
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < 6; i++)
                {
                    if(noGrid[0,i]!=0)
                    {
                        for (int j = 5; j >= i; j--)
                        {
                            if(noGrid[0,j]!=0)
                            {
                                if(i==j||i+1==j)
                                {
                                    break;
                                }
                                else
                                {
                                    for (int k = i+1; k < j; k++)
                                    {
                                        if (noGrid[0,k] == 0)
                                        {
                                            counter++;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    if (noGrid[1, i] != 0)
                    {
                        for (int j = 5; j >= i; j--)
                        {
                            if (noGrid[1, j] != 0)
                            {
                                if (i == j || i + 1 == j)
                                {
                                    break;
                                }
                                else
                                {
                                    for (int k = i+1; k < j; k++)
                                    {
                                        if (noGrid[1, k] == 0)
                                        {
                                            counter++;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                return counter;
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
