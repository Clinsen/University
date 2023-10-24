import 'doctor.dart';
import 'workday.dart';

void main() {
  List<WorkDay> workDays = [
    WorkDay('2023-10-01', 30, '09:00'),
    WorkDay('2023-10-02', 25, '08:30'),
    WorkDay('2023-10-03', 35, '09:15'),
    WorkDay('2023-10-04', 40, '09:05'),
    WorkDay('2023-10-05', 35, '09:15'),
    WorkDay('2023-10-05', 40, '08:50'),
  ];

  Map<String, Doctor> doctors = {
    'Dr. Smith': Doctor('Cardiologist', 'John Smith Oliver'),
    'Dr. Rodes': Doctor('Pediatrician', 'Jessica Rodes Brown'),
    'Dr. Cage': Doctor('Neurologist', 'Nicholas Cage Peterson'),
  };

  // 1. Середня кількість пацієнтів
  double averagePatients = workDays.map((day) => day.patientCount).reduce((a, b) => a + b) / workDays.length;

  // 2. Дні з максимальним навантаженням
  int maxPatientCount = workDays.map((day) => day.patientCount).reduce((a, b) => a > b ? a : b);
  int daysWithMaxLoad = workDays.where((day) => day.patientCount == maxPatientCount).length;

  // 3. Дні, коли лікар приймав після зазначеного часу (час видумав)
  String specifiedTime = '09:00';

  List<String> lateStartDays = [];

  for (var day in workDays) {
    var dayDateTime = DateTime.parse('${day.date} ${day.startTime}');
    var specifiedTimeDateTime = DateTime.parse('${day.date} $specifiedTime');

    if (dayDateTime.isAfter(specifiedTimeDateTime)) {
      lateStartDays.add(day.date);
    }
  }

  print('Середня кількість пацієнтів в день: $averagePatients');
  print('Кількість днів з максимальним навантаженням ($maxPatientCount пацієнтів): $daysWithMaxLoad');
  print('Дні, коли лікар починав приймати після $specifiedTime: $lateStartDays');
}