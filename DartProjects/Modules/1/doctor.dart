class Doctor {
  String specialty;
  String fullName;

  Doctor(this.specialty, this.fullName);

  @override
  String toString() => '$fullName, $specialty';
}