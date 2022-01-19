namespace IkiCore.Physics
{
	public static class SIConversion
    {
        public static float DegToRad(this float angle) => angle * 0.01745329251f;
        public static float RadToDeg(this float angle) => angle * 57.2957795131f;
        public static int SecondsToMinutes(int seconds) => (seconds - (seconds % 60)) / 60;
        public static int SecondsToHours(int seconds)
        {
            seconds = (seconds - (seconds % 60)) / 60;
            return (seconds - (seconds % 60)) / 60;
        }
        public static int SecondsToDays(int seconds)
        {
            seconds = (seconds - (seconds % 60)) / 60;
            seconds = (seconds - (seconds % 60)) / 60;
            return (seconds - (seconds % 24)) / 24;
        }
        public static int MinutesToSeconds(int minutes) => minutes * 60;
        public static int MinutesToHours(int minutes) => (minutes - (minutes % 60)) / 60;
        public static int MinutesToDays(int minutes)
        {
            minutes = (minutes - (minutes % 60)) / 60;
            return (minutes - (minutes % 24)) / 24;
        }
        public static int HoursToSeconds(int hours) => hours * 3600;
        public static int HoursToMinutes(int hours) => hours * 60;
        public static int HoursToDays(int hours) => (hours - (hours % 24)) / 24;
        public static int KilometerPerMinToMeterPerSec(int mPerSec) => (int)(mPerSec * 16.6666666666666666666666666666666f);
        public static int KilometerPerHourToMeterPerSec(int mPerSec) => (int)(mPerSec / 3.6f);
        public static int MeterPerSecToKilometerPerMin(int mPerSec) => (int)(mPerSec / 16.6666666666666666666666666666666f);
        public static int MeterPerSecToKilometerPerHour(int mPerSec) => (int)(mPerSec * 3.6f);
        public static float MeterPerSecToKilometerPerMin(float mPerSec) => mPerSec / 16.6666666666666666666666666666666f;
        public static float MeterPerSecToKilometerPerHour(float mPerSec) => mPerSec * 3.6f;
        public static double MeterPerSecToKilometerPerMin(double mPerSec) => mPerSec / 16.6666666666666666666666666666666d;
        public static double MeterPerSecToKilometerPerHour(double mPerSec) => mPerSec * 3.6d;
        public static float CelciusToFahrenheit(float celcius) => (celcius * 1.8f) + 32f;
        public static float FahrenheitToCelcius(float fahrenheit) => (fahrenheit - 32f) / 1.8f;
        public static float CelciusToKelvin(float celcius) => celcius + 273.15f;
        public static float KelvinToCelcius(float kelvin) => kelvin - 273.15f;
        public static float FarenheitToKelvin(float farenheit) => (farenheit - 32f) * 5f / 9f + 273.15f;
        public static float KelvinToFarenheit(float kelvin) => (kelvin - 273.15f) * 9f / 5f + 32f;
        public static int Voltage(int ampere, int resistance) => ampere * resistance;
        public static int Ampere(int voltage, int resistance) => voltage / resistance;
        public static int Resistance(int voltage, int ampere) => voltage / ampere;
        public static int PowerIE(int ampere, int voltage) => ampere / voltage;
        public static int PowerER(int voltage, int resistance) => (voltage * voltage) / resistance;
        public static int PowerIR(int ampere, int resistance) => (ampere * ampere) * resistance;
        public static float Voltage(float ampere, float resistance) => ampere * resistance;
        public static float Ampere(float voltage, float resistance) => voltage / resistance;
        public static float Resistance(float voltage, float ampere) => voltage / ampere;
        public static float PowerIE(float ampere, float voltage) => ampere / voltage;
        public static float PowerER(float voltage, float resistance) => (voltage * voltage) / resistance;
        public static float PowerIR(float ampere, float resistance) => (ampere * ampere) * resistance;
    }
}
