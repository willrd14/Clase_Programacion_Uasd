using System;

class VacationScale{
  int[] vacationDays = new int[7];

  public void setVacationScale(){
    vacationDays[0] = 10;
    vacationDays[1] = 12;
    vacationDays[2] = 14;
    vacationDays[3] = 15;
    vacationDays[4] = 20;
  }

  public void displayVacationDays(int yearOfService){
    Console.WriteLine("Tiempo de Servicio:{0}", vacationDays[yearOfService]);
  }
}