using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    internal class Program
    {
        static void Main()
        {
            Employee_and_tasks semen = new Employee_and_tasks("Семён");
            Employee_and_tasks rashid = new Employee_and_tasks("Рашид");
            Employee_and_tasks ilham = new Employee_and_tasks("Ильхам");
            Employee_and_tasks lukas = new Employee_and_tasks("Лукас");
            Employee_and_tasks orkadiy = new Employee_and_tasks("Оркадий");
            Employee_and_tasks volodya = new Employee_and_tasks("Володя");
            Employee_and_tasks ilshat = new Employee_and_tasks("Ильшат");
            Employee_and_tasks ivanych = new Employee_and_tasks("Иваныч");
            Employee_and_tasks ilya = new Employee_and_tasks("Илья");
            Employee_and_tasks vitya = new Employee_and_tasks("Витя");
            Employee_and_tasks zhenya = new Employee_and_tasks("Женя");
            Employee_and_tasks sergey = new Employee_and_tasks("Сергей");
            Employee_and_tasks lyaysan = new Employee_and_tasks("Ляйсан");
            Employee_and_tasks marat = new Employee_and_tasks("Марат");
            Employee_and_tasks dina = new Employee_and_tasks("Дина");
            Employee_and_tasks ildar = new Employee_and_tasks("Ильдар");
            Employee_and_tasks anton = new Employee_and_tasks   ("Антон");



            semen.Subordinates.Add(rashid);
            semen.Subordinates.Add(ilham);
            rashid.Subordinates.Add(lukas);
            ilham.Subordinates.Add(orkadiy);
            orkadiy.Subordinates.Add(sergey);
            orkadiy.Subordinates.Add(volodya);
            volodya.Subordinates.Add(sergey);
            orkadiy.Subordinates.Add(ilshat);
            volodya.Subordinates.Add(ilshat);
            ilshat.Subordinates.Add(ivanych);
            ivanych.Subordinates.Add(ilya);
            ivanych.Subordinates.Add(vitya);
            ivanych.Subordinates.Add(zhenya);
            sergey.Subordinates.Add(lyaysan);
            lyaysan.Subordinates.Add(marat);
            lyaysan.Subordinates.Add(dina);
            lyaysan.Subordinates.Add(ildar);
            lyaysan.Subordinates.Add(anton);




            semen.AssignTask("Разработать новую фичу", sergey);
            semen.AssignTask("Составить отчет", lukas);
            lukas.AssignTask("Настроить сервер", ilshat);
            ivanych.AssignTask("Сходить за печеньками", ilya);
            ilya.AssignTask("Помочь с работой", semen);
            Console.ReadKey();
        }
    }
}
