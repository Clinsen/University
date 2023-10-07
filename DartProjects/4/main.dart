class Conference<T extends Meeting> {
  String _name;
  String _venue;
  Map<DateTime, T> _meetings = {};

  Conference(this._name, this._venue);

  String get name => _name;
  String get venue => _venue;
  Map<DateTime, T> get meetings => _meetings;

  set name(String name) => _name = name;
  set venue(String venue) => _venue = venue;

  void addMeeting(DateTime date, String topic, int participants, T meeting) {
    _meetings[date] = meeting;
    _meetings[date]?.date = date;
    _meetings[date]?.topic = topic;
    _meetings[date]?.participants = participants;
  }

  double calculateAverageParticipants() {
    if (_meetings.isEmpty) {
      return 0;
    }
    int totalParticipants = 0;
    _meetings.forEach((_, meeting) {
      totalParticipants += meeting.participants;
    });
    return totalParticipants / _meetings.length;
  }

  T? findMeetingWithMostParticipants() {
    if (_meetings.isEmpty) {
      return null;
    }
    T? meetingWithMostParticipants;
    int maxParticipants = 0;
    _meetings.forEach((_, meeting) {
      if (meeting.participants > maxParticipants) {
        maxParticipants = meeting.participants;
        meetingWithMostParticipants = meeting;
      }
    });
    return meetingWithMostParticipants;
  }
}

class Meeting {
  DateTime _date;
  String _topic;
  int _participants;

  Meeting(this._date, this._topic, this._participants);

  DateTime get date => _date;
  String get topic => _topic;
  int get participants => _participants;

  set date(DateTime date) {
    _date = date;
  }
  set topic(String topic) {
    _topic = topic;
  }
  set participants(int participants) {
    _participants = participants;
  }

  double getTopicNameLength() {
    return _topic.length.toDouble();
  }
}

void main() {
  Conference<Meeting> conference = Conference("Dart Conference", "Unknown");
  conference._venue = "Online";

  conference.addMeeting(DateTime(2023, 10, 3), "Monday meeting", 50, Meeting(DateTime(2023, 10, 3), "", 0));
  conference.addMeeting(DateTime(2023, 10, 4), "Wednesday meeting", 70, Meeting(DateTime(2023, 10, 4), "", 0));
  conference.addMeeting(DateTime(2023, 10, 5), "Friday meeting", 60, Meeting(DateTime(2023, 10, 5), "", 0));

  print("Conference Name: ${conference.name}");
  print("Conference Venue: ${conference.venue}");

  print("\nMeetings:");
  conference.meetings.forEach((date, meeting) {
    print("Date: ${meeting.date}, Topic: ${meeting.topic}, Participants: ${meeting.participants}");
  });

  print("\nAverage Participants: ${conference.calculateAverageParticipants()}");
  Meeting? meetingWithMostParticipants = conference.findMeetingWithMostParticipants();
  if (meetingWithMostParticipants != null) {
    print("Meeting with Most Participants: ${meetingWithMostParticipants.topic}");
  } else {
    print("No meetings found.");
  }

  double topicNameLength = conference.meetings.values.first.getTopicNameLength();
  print("Length of the first meeting's topic name: $topicNameLength\n");
}
