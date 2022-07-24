

namespace Interfaces_and_Abstraction___Military_Elite
{
    using Interfaces_and_Abstraction___Military_Elite.Models;
    using Interfaces_and_Abstraction___Military_Elite.Models.Sets;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Private> privateList = new List<Private>();
            List<LieutenantGeneral> ltGeneralList = new List<LieutenantGeneral>();
            List<Engineer> engineerList = new List<Engineer>();
            List<Commando> commandoList = new List<Commando>();
            List<Spy> spyList = new List<Spy>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitInput = input.Split().ToArray();
                string mainArg = splitInput[0];


                if (mainArg == "Private")
                {
                    int iD = int.Parse(splitInput[1]);
                    string firstName = splitInput[2];
                    string lastName = splitInput[3];
                    decimal salary = decimal.Parse(splitInput[4]);

                    Private priv = new Private
                        (iD, firstName, lastName, salary);

                    privateList.Add(priv);
                    
                    priv.AddPrivateToList(iD, firstName, lastName,salary);
                    Console.WriteLine(priv.ToString());
                    
                }
                else if (mainArg == "LieutenantGeneral")
                {
                    int iD = int.Parse(splitInput[1]);
                    string firstName = splitInput[2];
                    string lastName = splitInput[3];
                    decimal salary = decimal.Parse(splitInput[4]);

                    List<Private> privateForCommand = new List<Private>();
                    for (int i = 4 + 1; i < splitInput.Length; i++)
                    {
                        int privateID = int.Parse(splitInput[i]);

                        Private privateFound = privateList.Find(x => x.ID == privateID);

                        privateForCommand.Add(privateFound);
                    }

                    LieutenantGeneral ltGeneral = new LieutenantGeneral
                        (iD, firstName, lastName, salary, privateForCommand);

                    ltGeneralList.Add(ltGeneral);
                    ltGeneral.AddLtGeneralToList(iD, firstName, lastName, salary, privateForCommand);
                    Console.WriteLine(ltGeneral.ToString());

                }
                else if (mainArg == "Engineer")
                {
                    int iD = int.Parse(splitInput[1]);
                    string firstName = splitInput[2];
                    string lastName = splitInput[3];
                    decimal salary = decimal.Parse(splitInput[4]);
                    string corps = splitInput[5];
                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }

                    List<Repair> repairList = new List<Repair>();
                    for (int i = 5 + 1; i < splitInput.Length; i += 2)
                    {
                        string repairPart = splitInput[i];
                        int repairTime = int.Parse(splitInput[i + 1]);

                        Repair repair = new Repair(repairPart, repairTime);
                        repairList.Add(repair);
                    }

                    Engineer engineer = new Engineer
                        (corps, iD, firstName, lastName, salary, repairList);

                    engineerList.Add(engineer);
                    engineer.AddEngineerToList(corps, iD, firstName, lastName, salary, repairList);
                    Console.WriteLine(engineer.ToString());

                }
                else if (mainArg == "Commando")
                {
                    int iD = int.Parse(splitInput[1]);
                    string firstName = splitInput[2];
                    string lastName = splitInput[3];
                    decimal salary = decimal.Parse(splitInput[4]);
                    string corps = splitInput[5];
                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }
                    List<Mission> missionList = new List<Mission>();
                    for (int i = 5 + 1; i < splitInput.Length; i += 2)
                    {
                        string missionName = splitInput[i];
                        string missionState = splitInput[i + 1];
                        if (missionState == "inProgress" || missionState == "Finished")
                        {
                            Mission mission = new Mission(missionName, missionState);
                            missionList.Add(mission);
                        }

                        
                    }
                   
                    Commando commando = new Commando(salary, iD, firstName, lastName, corps, missionList);
                    commandoList.Add(commando);
                    commando.AddCommandoToList(salary,iD,firstName,lastName,corps,missionList);
                    Console.WriteLine(commando.ToString());
                }

                else if (mainArg == "Spy")
                {
                    int iD = int.Parse(splitInput[1]);
                    string firstName = splitInput[2];
                    string lastName = splitInput[3];
                    int codeNumber = int.Parse(splitInput[4]);

                    Spy spy = new Spy(iD, firstName, lastName, codeNumber);
                    spyList.Add(spy);
                    spy.AddSpyToList(iD, firstName, lastName, codeNumber);
                    Console.WriteLine(spy.ToString());
                }


            }

            
        }
    }
}
