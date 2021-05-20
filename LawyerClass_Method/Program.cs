﻿using System;

namespace LawyerClass_Method
{
    class Program
    {
        static void Main(string[] args)
        {  //instantiate new lawyer
            Lawyer jamesTiuLawyer = new Lawyer("James", 5, 2000, 15, 4);
            Console.WriteLine($"Facts: {jamesTiuLawyer.name} has {jamesTiuLawyer.numberOfTrials} trials and {jamesTiuLawyer.numberOfHearings} hearings");
            //Console.ReadLine();

            //instantiate another lawyer
            Lawyer jessicaJimenez = new Lawyer("Jessica", 4, 1000, 14, 7);
            Console.WriteLine($"Facts : {jessicaJimenez.name} has {jessicaJimenez.numberOfTrials} trials and {jessicaJimenez.numberOfHearings} hearings");
            //Console.ReadLine();

            //instantiate another lawyer, potential juror, lawfirm employee, jury trial

            Lawyer meghanMelendez = new Lawyer("megMel", 6, 2500, 16, 5);
            {
                //if statement to detrmine which lawyer prevails, using number of trials as the determining factor
                if (jamesTiuLawyer.numberOfHearings > meghanMelendez.numberOfHearings)
                {
                    Console.WriteLine("James' client prevails, based upon # of hearings");
                }
                else
                {
                    Console.WriteLine("Jessica's client prevails, based upon # of hearingss.");
                }
                //Console.ReadLine();

            }

            PotentialJuror juror1 = new PotentialJuror(27, "Jess", "not guilty");
            LegalFirmEmployee joseAlvarado = new LegalFirmEmployee("Jose", "Alvarado", "j.a.@firm.com", 40, 40, new DateTime(1999, 1, 16));

            Trial juryTrial = new Trial("Smith v Jones", 30, 12, "Mowrery", 20, 30);
            {
                //if statement to detrmine which lawyer prevails, using number of trials as the determining factor
                if (jamesTiuLawyer.numberOfTrials > jessicaJimenez.numberOfTrials)
                {
                    Console.WriteLine("James' client prevails at trial, based upon # of trials");
                }
                else
                {
                    Console.WriteLine("Jessica client prevails at trial, based upon # of trials.");
                }
                //Console.ReadLine();

            }

            {
                jessicaJimenez.DisplayLawyerParameters();
                jamesTiuLawyer.DisplayLawyerParameters();
                meghanMelendez.DisplayLawyerParameters();
                meghanMelendez.CheckInOffice();
                meghanMelendez.CareerTotalTrials();
                meghanMelendez.CareerTotalHearings();
                juryTrial.DisplayTrialParameters();
                juryTrial.TotalNumberAppearances();
                juryTrial.JurySelection();
                juror1.ToString();
                juror1.JurorFacts();
                joseAlvarado.LawFirmEmployePrintData();
                Console.Clear();

                Console.ReadLine();

            }
            //work a method to calculate a monthly wage


        }
    }
}
