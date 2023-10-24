class WorkDay {
  String date;
  int patientCount;
  String startTime;

  WorkDay(this.date, this.patientCount, this.startTime);

  @override
  String toString() => 'Date: $date, Patients: $patientCount, Start Time: $startTime';
}