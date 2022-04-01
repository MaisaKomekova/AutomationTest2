
using System;
using System.Configuration;

namespace AT_Email.WebDriver
{
    public class Configuration
    {
     
        public static string GetEnviromentVar(string var, string defaultValue)
        {
            return ConfigurationManager.AppSettings[var] ?? defaultValue;
        }

        public static string ElementTimeout => GetEnviromentVar("ElementTimeout","30");

        public static string Browser => GetEnviromentVar("Browser", "Chrome");

        public static string StartUrl => GetEnviromentVar("StartUrl", "https://passport.yandex.ru/auth?from=mail&origin=hostroot_homer_auth_ru&retpath=https%3A%2F%2Fmail.yandex.ru%2F%3Fnoretpath%3D1&backpath=https%3A%2F%2Fmail.yandex.ru%3Fnoretpath%3D1");

    }
}
