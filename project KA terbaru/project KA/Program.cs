using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Media;
using System.Diagnostics;
using System.Globalization;

namespace project_KA {

    class Program {
        public static int countgerbong = 0;
        public static int htng = 1;
        public static string kode;
        public static string tempatduduk;
        public static string tempnobook = "";
        public static int tempgerbong;

        //maxsize windows
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;

        static void MaxWindows() {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }

        static SoundPlayer greetings = new SoundPlayer();

        static void gb() {
            //membuat garis bawah
            int koorBrs = 11;
            int koorKlm = 0;
            int width = Console.WindowWidth - 1;
            int height = Console.WindowHeight - 1;
            Console.SetCursorPosition(koorKlm, koorBrs);
            while (koorKlm <= width) {

                Console.SetCursorPosition(koorKlm, koorBrs);
                Console.Write("=");
                koorKlm += 1;
            }
        }

        static void cursor(int side1, int top1) {
            Console.SetCursorPosition(side1, top1);
        }

        public static Random rnd = new Random();

        static void main() {
            string[] arr1 = new string[6];

            arr1[0] = "         __      __          _                                               ";
            arr1[1] = "    o O O\\ \\    / / ___     | |     __      ___    _ __     ___           ";
            arr1[2] = "   o      \\ \\/\\/ / / -_)    | |    / _|    / _ \\  | '  \\   / -_)     _    ";
            arr1[3] = "  TS__[O]  \\_/\\_/  \\___|   _|_|_   \\__|_   \\___/  |_|_|_|  \\___|   _(_)_  ";
            arr1[4] = " {======|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|   ";
            arr1[5] = "./o--000\' \"-0-0-'\"'-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'  ";

            String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
            int numColors = colorNames.Length;

            ConsoleKeyInfo ckey;
            int kx = Console.WindowWidth - 1;
            int ky = 5;

            main2();
            gb();
         
            greetings.SoundLocation = Directory.GetCurrentDirectory() + @"\sound\train.wav";
            greetings.Play();

            do {
                //mengubah warna terus menerus secara random untuk animasi kata welcome
                Console.CursorVisible = false;
                string colorName = colorNames[rnd.Next(numColors)];
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                Console.ForegroundColor = color;

                for (int i = 0; i < 6; i++) {
                    int cek = kx;
                    Console.SetCursorPosition(cek, ky + i);
                    foreach (char c in arr1[i]) {
                        if (cek == Console.WindowWidth) {
                            cek = 0;
                            Console.SetCursorPosition(cek, ky + i);
                        }
                        Console.Write(c);
                        cek++;
                    }
                }
                kx--;
                if (kx < 0) {
                    kx = Console.WindowWidth - 1;
                }

                if (Console.KeyAvailable) {
                    ckey = Console.ReadKey(true);
                    if (ckey.Key == ConsoleKey.Enter) {
                        break;
                    }
                }
                Thread.Sleep(50);
            } while (true);

            Console.Clear();
            greetings.SoundLocation = Directory.GetCurrentDirectory() + @"\sound\virtual_male.wav";
            //greetings.SoundLocation = Directory.GetCurrentDirectory() + @"\sound\virtual_woman.wav";

            greetings.Play();
        }

        static void main2() {
            string[] ta = new string[9];
            ta[0] = " __     __  ________                   __           ";
            ta[1] = "|  \\   |  \\|        \\                 |  \\          ";
            ta[2] = "| $$   | $$ \\$$$$$$$$______   ______   \\$$ _______  ";
            ta[3] = "| $$   | $$   | $$  /      \\ |      \\ |  \\|       \\ ";
            ta[4] = " \\$$\\ /  $$   | $$ |  $$$$$$\\ \\$$$$$$\\| $$| $$$$$$$\\";
            ta[5] = "  \\$$\\  $$    | $$ | $$   \\$$/      $$| $$| $$  | $$";
            ta[6] = "   \\$$ $$     | $$ | $$     |  $$$$$$$| $$| $$  | $$";
            ta[7] = "    \\$$$      | $$ | $$      \\$$    $$| $$| $$  | $$";
            ta[8] = "     \\$        \\$$  \\$$       \\$$$$$$$ \\$$ \\$$   \\$$";

            int top1 = 20;
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= 8; i++) {
                cursor(Console.WindowWidth / 2 - 30, top1);
                foreach (char c in ta[i]) {
                    Console.Write(c);
                }
                top1++;
                Console.WriteLine("");
            }
            Console.ResetColor();
        }

        static void menu(int cnt) {
            string[] awal = new string[6];
            awal[0] = " __    __ _           _                         _     _                       _ _ _          _              _         ___ ";
            awal[1] = "/ / /\\ \\ \\ |__   __ _| |_  __      _____  _   _| | __| |  _   _  ___  _   _  | (_) | _____  | |_ ___     __| | ___   / _ \\";
            awal[2] = "\\ \\/  \\/ / '_ \\ / _` | __| \\ \\ /\\ / / _ \\| | | | |/ _` | | | | |/ _ \\| | | | | | | |/ / _ \\ | __/ _ \\   / _` |/ _ \\  \\// /";
            awal[3] = " \\  /\\  /| | | | (_| | |_   \\ V  V / (_) | |_| | | (_| | | |_| | (_) | |_| | | | |   <  __/ | || (_) | | (_| | (_) |   \\/ ";
            awal[4] = "  \\/  \\/ |_| |_|\\__,_|\\__|   \\_/\\_/ \\___/ \\__,_|_|\\__,_|  \\__, |\\___/ \\__,_| |_|_|_|\\_\\___|  \\__\\___/   \\__,_|\\___/    () ";
            awal[5] = "                                                          |___/                                                           ";
            int top = 1;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i <= 5; i++) {
                cursor(Console.WindowWidth / 2 - 65, top);
                foreach (char c in awal[i]) {
                    Console.Write(c);
                }
                top++;
                Console.WriteLine("");
            }

            Console.ResetColor();

            string[] gambar = new string[10];
            gambar[0] = " _             _        _                 _    _             ";
            gambar[1] = "| |           | |      | |               | |  (_)            ";
            gambar[2] = "| | _____   __| | ___  | |__   ___   ___ | | ___ _ __   __ _ ";
            gambar[3] = "| |/ / _ \\ / _` |/ _ \\ | '_ \\ / _ \\ / _ \\| |/ / | '_ \\ / _` |";
            gambar[4] = "|   < (_) | (_| |  __/ | |_) | (_) | (_) |   <| | | | | (_| |";
            gambar[5] = "|_|\\_\\___/ \\__,_|\\___| |_.__/ \\___/ \\___/|_|\\_\\_|_| |_|\\__, |";
            gambar[6] = "                                                        __/ |";
            gambar[7] = "                                                       |___/ ";
            gambar[8] = "                                                                  ";
            gambar[9] = "==============================================================";

            top = 10;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 8; i++) {
                if (cnt == 1) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    gambar[8] = gambar[9];
                }
                cursor(Console.WindowWidth / 2 - 36, top);
                foreach (char a in gambar[i]) {
                    Console.Write(a);
                }
                top++;
                Console.WriteLine("");
            }

            Console.ResetColor();

            string[] gambar2 = new string[8];
            gambar2[0] = " _ __   ___ _ __ ___   ___  ___  __ _ _ __   __ _ _ __  ";
            gambar2[1] = "| '_ \\ / _ \\ '_ ` _ \\ / _ \\/ __|/ _` | '_ \\ / _` | '_ \\ ";
            gambar2[2] = "| |_) |  __/ | | | | |  __/\\__ \\ (_| | | | | (_| | | | |";
            gambar2[3] = "| .__/ \\___|_| |_| |_|\\___||___/\\__,_|_| |_|\\__,_|_| |_|";
            gambar2[4] = "| |                                                     ";
            gambar2[5] = "|_|                                                     ";
            gambar2[6] = "                                                                         ";
            gambar2[7] = "========================================================";
            top = 19;
            for (int i = 0; i <= 6; i++) {
                if (cnt == 2) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    gambar2[6] = gambar2[7];
                }
                cursor(Console.WindowWidth / 2 - 34, top);
                foreach (char b in gambar2[i]) {
                    Console.Write(b);
                }
                top++;
                Console.WriteLine("");
            }
            Console.ResetColor();
            string[] gambar3 = new string[8];
            gambar3[0] = "   ___           _               _ ";
            gambar3[1] = "  |_  |         | |             | |";
            gambar3[2] = "    | | __ _  __| |_      ____ _| |";
            gambar3[3] = "    | |/ _` |/ _` \\ \\ /\\ / / _` | |";
            gambar3[4] = "/\\__/ / (_| | (_| |\\ V  V / (_| | |";
            gambar3[5] = "\\____/ \\__,_|\\__,_| \\_/\\_/ \\__,_|_|";
            gambar3[6] = "                                                         ";
            gambar3[7] = "===================================";
            top = 26;
            for (int i = 0; i <= 6; i++) {
                if (cnt == 3) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    gambar3[6] = gambar3[7];
                }
                cursor(Console.WindowWidth / 2 - 25, top);
                foreach (char b in gambar3[i]) {
                    Console.Write(b);
                }
                top++;
                Console.WriteLine("");
            }
        }



        static void tiket(int top2) {
            string[] tkt = new string[20];
            tkt[0] = "*******************************************************************************";
            tkt[1] = "*        |                                                                   *";
            tkt[2] = "*        |                                                                  *";
            tkt[3] = "*        |                                                                 *";
            tkt[4] = "*        |                                                                 *";
            tkt[5] = "*        |                                                                  *";
            tkt[6] = "*        |                                                                   *";
            tkt[7] = "*        |                                                                   *";
            tkt[8] = "*        |                                                                  *";
            tkt[9] = "*        |                                                                 *";
            tkt[10] = "*        |                                                                 *";
            tkt[11] = "*        |                                                                  *";
            tkt[12] = "*        |                                                                   *";
            tkt[13] = "*        |                                                                  *";
            tkt[14] = "*        |________________________________________________________________*";
            tkt[15] = "*        X                                                                *";
            tkt[16] = "*       0 0                                                               *";
            tkt[17] = "*        |                                                                 *";
            tkt[18] = "******************************************************************************";

            int sides2 = Console.WindowWidth / 2 - 36;
            int tmp = top2;

            string line;
            int count = 1;
            bool unseen = true;

            do {
                try {
                    cursor(Console.WindowWidth / 2 - 30, 10);
                    Console.Write("Masukkan kode anda untuk mengecek tiket kereta Api ");
                    cursor(Console.WindowWidth / 2 - 30, 14);
                    Console.Write("Masukkan kode = ");

                    Console.SetCursorPosition(Console.WindowWidth / 2 - 37, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("** Press TAB to UNHIDE the Booking Code and TAB again to HIDE it **");
                    Console.ResetColor();
                    cursor(Console.WindowWidth / 2 - 30, 10);
                    Console.Write("Masukkan kode anda untuk mengecek tiket kereta Api ");
                    cursor(Console.WindowWidth / 2 - 30, 14);
                    Console.Write("Silahkan Masukan kode booking Anda = ");

                    kode = "";
                    int hapus;
                    do {
                        cursor(Console.WindowWidth/2 + 7, 14);
                        if (unseen) {
                            for (int i = 0; i < kode.Length; i++)
                                Console.Write("*");
                        } else {
                            Console.Write(kode);
                        }
                        ConsoleKeyInfo code = Console.ReadKey(true);
                        if (code.Key != ConsoleKey.Backspace && code.Key != ConsoleKey.Enter && code.Key != ConsoleKey.Tab) {
                            kode += code.KeyChar;
                        } else if (code.Key == ConsoleKey.Backspace && kode.Length > 0) {
                            hapus = Console.WindowWidth/2 +7 + kode.Length - 1;
                            kode = kode.Remove(kode.Length - 1);
                            Console.SetCursorPosition(hapus, 14);
                            Console.Write(" ");
                        } else if (code.Key == ConsoleKey.Tab) {
                            unseen = !(unseen);
                        } else if (code.Key == ConsoleKey.Enter)
                            break;
                    } while (true);

                    Console.Clear();
                    if (kode.Length == 0) {
                        throw new Exception("");
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                Console.Clear();
            } while (kode.Length == 0);

            //mencek isi file untuk tiket berdasarkan kodebooking
            if (File.Exists("data.txt")) {
                StreamReader baca = new StreamReader("data.txt");

                while ((line = baca.ReadLine()) != null) {
                    if (line.Contains(kode)) {
                        break;
                    }
                    count++;
                }
                baca.Close();
                Console.Clear();
                if (count > File.ReadAllLines("data.txt").Length) {
                    cursor(Console.WindowWidth / 2 - 30, 10);
                    Console.WriteLine("maaf kode booking yang ada masukkan tidak ada ....!!!");
                } else {
                    string a = File.ReadLines("data.txt").Skip(count - 1).Take(1).First();

                    string temp = "";
                    int idx = 0;
                    string[] isi = new string[101];

                    for (int i = 0; i < a.Length; i++) {
                        if (a[i] != ',') {
                            temp += a[i];
                        } else {
                            isi[idx] = temp;
                            temp = "";
                            idx += 1;
                        }
                    }
                    isi[idx] = temp;

                    for (int i = 0; i <= 18; i++) {
                        cursor(sides2, top2);
                        for (int j = 0; j < tkt[i].Length; j++) {
                            if (j > 0 && j < 9 && i != 0 && i != 18) {
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                            } else {
                                Console.ResetColor();
                            }
                            if (tkt[i][j] == 'X' || tkt[i][j] == '0') {

                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.Write(tkt[i][j]);
                        }
                        top2++;
                        Console.WriteLine("");
                    }
                    top2 = tmp;

                    cursor(sides2 + 20, top2 + 1);
                    Console.WriteLine("tiket pemesanan Kereta Api");
                    cursor(sides2 + 11, top2 + 3);
                    Console.Write($"Nama       : {isi[0],-12}");
                    cursor(sides2 + 11, top2 + 5);
                    Console.Write($"No Booking : {isi[7],-12} \t Gerbong/Seat   :{isi[5]}/{isi[6]}");
                    cursor(sides2 + 11, top2 + 7);
                    Console.Write($"Asal Kota  : {isi[1],-12} \t kota tujuan    : {isi[2]}");
                    cursor(sides2 + 11, top2 + 9);
                    Console.Write($"Tanggal    : {isi[3],-12}");
                    cursor(sides2 + 11, top2 + 11);
                    Console.Write($"Jadwal     : {isi[4],-12}");
                }
            } else {
                Console.WriteLine("Tidak terdapat file data.txt");
            }


        }

        struct formulirawal {
            public string nama, asal, tujuan, date, time, seat;
            public void isidata() {
                Console.CursorVisible = true;
                bool ok = false;
                nama = "";
                asal = "";
                tujuan = "";
                date = "";
                DateTime dt;
                do {
                    ConsoleKeyInfo tombol;
                    char input;
                    bool next = false;
                    do {
                        Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 8);
                        Console.Write(nama.ToUpper());
                        tombol = Console.ReadKey(true);
                        input = tombol.KeyChar;
                        int hapus;
                        if ((Char.IsLetter(input) || input == ' ') && nama.Length < 20) {
                            nama += input;
                        } else if (tombol.Key == ConsoleKey.Backspace && nama.Length > 0) {
                            hapus = (Console.WindowWidth) / 2 + 5 + nama.Length - 1;
                            nama = nama.Remove(nama.Length - 1);
                            Console.SetCursorPosition(hapus, Console.WindowHeight / 4 + 8);
                            Console.Write(" ");
                        } else if (tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.Enter) {
                            do {
                                Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 9);
                                Console.Write(asal.ToUpper());
                                tombol = Console.ReadKey(true);
                                input = tombol.KeyChar;
                                if ((Char.IsLetter(input) || input == ' ') && asal.Length < 20) {
                                    asal += input;
                                } else if (tombol.Key == ConsoleKey.Backspace && asal.Length > 0) {
                                    hapus = (Console.WindowWidth) / 2 + 5 + asal.Length - 1;
                                    asal = asal.Remove(asal.Length - 1);
                                    Console.SetCursorPosition(hapus, Console.WindowHeight / 4 + 9);
                                    Console.Write(" ");
                                } else if (tombol.Key == ConsoleKey.UpArrow) {
                                    //Console.SetCursorPosition(Console.WindowWidth / 2 + 5, 5);
                                    break;
                                } else if (tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.Enter) {
                                    do {
                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 10);
                                        Console.Write(tujuan.ToUpper());
                                        tombol = Console.ReadKey(true);
                                        input = tombol.KeyChar;
                                        if ((Char.IsLetter(input) || input == ' ') && tujuan.Length < 20) {
                                            tujuan += input;
                                        } else if (tombol.Key == ConsoleKey.Backspace && tujuan.Length > 0) {
                                            hapus = (Console.WindowWidth) / 2 + 5 + tujuan.Length - 1;
                                            tujuan = tujuan.Remove(tujuan.Length - 1);
                                            Console.SetCursorPosition(hapus, Console.WindowHeight / 4 + 10);
                                            Console.Write(" ");
                                        } else if (tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.Enter) {
                                            do {
                                                Console.ResetColor();
                                                Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 11);
                                                Console.Write(date);
                                                tombol = Console.ReadKey(true);
                                                input = tombol.KeyChar;
                                                if (Char.IsDigit(input) && date.Length < 10) {
                                                    date += input;
                                                    if (date.Length == 2 || date.Length == 5)
                                                        date += '/';
                                                } else if (tombol.Key == ConsoleKey.Backspace && date.Length > 0) {

                                                    hapus = (Console.WindowWidth) / 2 + 5 + date.Length - 1;
                                                    date = date.Remove(date.Length - 1);
                                                    Console.SetCursorPosition(hapus, Console.WindowHeight / 4 + 11);
                                                    int pnjg = (Console.WindowWidth) / 2 + 5;
                                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                                    if (hapus == pnjg || hapus == pnjg + 1)
                                                        Console.Write("D");
                                                    else if (hapus == pnjg + 2 || hapus == pnjg + 5)
                                                        Console.Write("/");
                                                    else if (hapus == pnjg + 3 || hapus == pnjg + 4)
                                                        Console.Write("M");
                                                    else
                                                        Console.Write("Y");
                                                    Console.ResetColor();
                                                } else if (tombol.Key == ConsoleKey.UpArrow) {
                                                    //Console.SetCursorPosition(Console.WindowWidth / 2 + 5, 7);
                                                    break;
                                                } else if (tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.Enter) {
                                                    do {
                                                        Console.CursorVisible = true;
                                                        Console.ResetColor();
                                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 12);
                                                        time = waktu(htng);
                                                        Console.Write(time);
                                                        tombol = Console.ReadKey(true);
                                                        input = tombol.KeyChar;
                                                        //Console.CursorVisible = false;
                                                        if (tombol.Key == ConsoleKey.UpArrow)
                                                            break;
                                                        else {
                                                            switch (tombol.Key) {
                                                                case ConsoleKey.LeftArrow:
                                                                    if (htng == 2 || htng == 3) htng -= 1;
                                                                    //else htng -= 0;
                                                                    Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 12);
                                                                    Console.Write(time);
                                                                    //Console.CursorVisible = false;
                                                                    break;
                                                                case ConsoleKey.RightArrow:
                                                                    if (htng == 1 || htng == 2) htng += 1;
                                                                    //else htng += 0;
                                                                    Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 12);
                                                                    Console.Write(time);
                                                                    //Console.CursorVisible = false;
                                                                    break;
                                                            }
                                                        }
                                                        if (tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.Enter) {
                                                            do {
                                                                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 4 + 15);
                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                Console.Write("SUBMIT");
                                                                tombol = Console.ReadKey(true);
                                                                bool yes = false;
                                                                if (DateTime.TryParse(date, out dt)) {
                                                                    
                                                                }
                                                                if (tombol.Key == ConsoleKey.UpArrow) {
                                                                    Console.ResetColor();
                                                                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 4 + 15);
                                                                    Console.ForegroundColor = ConsoleColor.Blue;
                                                                    Console.Write("SUBMIT");
                                                                    Console.ResetColor();
                                                                    break;
                                                                } else if (tombol.Key == ConsoleKey.Enter) {
                                                                    if (!DateTime.TryParse(date, out dt)) {
                                                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 11);
                                                                        Console.Write("** TANGGAL TIDAK VALID **");
                                                                    } else {
                                                                        var today = DateTime.Now;
                                                                        var ourdate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                                                        if (ourdate <= today) {
                                                                            Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 11);
                                                                            Console.Write("** TANGGAL TIDAK VALID **");
                                                                        } else if (ourdate > today)
                                                                            yes = true;
                                                                    }
                                                                    if (nama == "" || asal == "" || tujuan == "" ) {
                                                                        if (nama == "") {
                                                                            Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 8);
                                                                            Console.Write("** NAMA TIDAK VALID **");
                                                                        }
                                                                        if (asal == "") {
                                                                            Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 9);
                                                                            Console.Write("** ASAL TIDAK VALID **");
                                                                        }
                                                                        if (tujuan == "") {
                                                                            Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 10);
                                                                            Console.Write("** TUJUAN TIDAK VALID **");
                                                                        }
                                                                    }
                                                                    if (nama != "" && asal != "" && tujuan != "" &&  yes)  {
                                                                        next = true;
                                                                    }
                                                                }
                                                                Console.ResetColor();
                                                            } while (!next);

                                                        }
                                                    } while (!next);
                                                }
                                                if (!DateTime.TryParse(date, out dt)) {
                                                    Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 11);
                                                    Console.Write("                         ");
                                                }
                                            } while (!next);
                                        } else if (tombol.Key == ConsoleKey.UpArrow) {
                                            //Console.SetCursorPosition(Console.WindowWidth / 2 + 5, 6);
                                            break;
                                        }
                                        if (tujuan.Length > 0) {
                                            Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 10);
                                            Console.Write("                        ");
                                        }
                                    } while (!next);
                                }
                                if (asal.Length > 0) {
                                    Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 9);
                                    Console.Write("                      ");
                                }
                            } while (!next);
                        }
                        if (nama.Length > 0) {
                            Console.SetCursorPosition(Console.WindowWidth / 2 + 40, Console.WindowHeight / 4 + 8);
                            Console.Write("                      ");
                        }
                    } while (!next);
                    ok = true;
                } while (!ok);

            }

            static string waktu(int cnt) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                cursor(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 12);
                if (cnt == 1) {
                    return "08:00 - 10:00";
                } else if (cnt == 2) {
                    return "13:00 - 15:00";
                } else {
                    return "19:00 - 21:00";
                }

            }

            public void simpandata() {
                StreamWriter simpan = new StreamWriter("data.txt", true);
                simpan.WriteLine($"{nama.ToLower()},{asal.ToLower()},{tujuan.ToLower()},{date},{time},{tempgerbong},{tempatduduk},{tempnobook}");
                simpan.Close();
            }

            public string[,] cekgerbong() {
                string line;
                string[,] arrgerbong = new string[1001, 1001];
                string semen = $"({date[0]}{date[1]})({date[3]}{date[4]})({date[6]}{date[7]}{date[8]}{date[9]})";
                string tara = $"{time[0]}{time[1]}";
                string namaFile = $"{asal}_{tujuan}_{semen}_{tara}.txt";
                //string tmpt = Directory.GetCurrentDirectory() + @"\{namaFile}.txt";

                //Console.WriteLine(namaFile);

                if (File.Exists("data.txt")) {
                    StreamReader baca = new StreamReader("data.txt");
                    //string filepath = string.Format("{0}_{1}_{2}_{3}.txt",asal,tujuan,date,time);
                    StreamWriter tulis = new StreamWriter(namaFile);
                    tulis.WriteLine($"Jadwal Kereta Api dari {asal} ke {tujuan} pada Tanggal {date} dan jam {time}:\n");
                    while ((line = baca.ReadLine()) != null) {
                        if (line.Contains(date) && line.Contains(time) && line.Contains(asal) && line.Contains(tujuan)) {

                            //string s = File.ReadLines("data.txt").Skip(count - 1).Take(1).First();
                            //string s = baca.ReadLine();
                            string temp = "";
                            int idx = 0;
                            string[] isi2 = new string[101];

                            for (int i = 0; i < line.Length; i++) {
                                if (line[i] != ',') {
                                    temp += line[i];
                                } else {
                                    isi2[idx] = temp;
                                    temp = "";
                                    idx += 1;
                                }
                            }

                            isi2[idx] = temp;
                            for (int i = 0; i < 8; i++) {
                                if (i == 0 || i == 5 || i == 6)
                                    tulis.Write($"{isi2[i]}, ");
                                else if (i == 7)
                                    tulis.Write(isi2[i]);
                            }
                            tulis.WriteLine();
                            arrgerbong[countgerbong, 0] = isi2[5].ToString();
                            arrgerbong[countgerbong, 1] = isi2[6];
                            countgerbong++;

                        }

                    }
                    tulis.Close();
                    baca.Close();
                } else {
                    Console.Write("data.txt tidak terdapat");
                }
                /*Console.Write($"count = {count}");
                for(int i = 0; i < count+1; i++) {
                    for(int j = 0; j < 2; j++) {
                        Console.Write(arrgerbong[i, j]);
                        Console.Write(' ');
                    }
                    Console.WriteLine("");
                }*/
                return arrgerbong;
            }

        }
        static string nobook() {
            int kode_booking;
            int kode_booking1;
            char kb1;
            int kode_booking2;
            char kb2;
            Random rdn = new Random();
            kode_booking1 = rdn.Next(65, 91);
            kode_booking2 = rdn.Next(65, 91);
            kb1 = (char)kode_booking1;
            kb2 = (char)kode_booking2;
            kode_booking = rdn.Next(1000, 10000);
            string nobooking = String.Concat(kb1, kb2, kode_booking);
            return nobooking;
        }
        public static void penutup() {
            string[] tutup = new string[6];
            tutup[0] = "  _            _                   _             _ _       _       _       _                      _       _          _               ";
            tutup[1] = " | |          (_)                 | |           (_) |     | |     | |     | |                    | |     | |        | |              ";
            tutup[2] = " | |_ ___ _ __ _ _ __ ___   __ _  | | ____ _ ___ _| |__   | |_ ___| | __ _| |__    _ __ ___   ___| | __ _| | ___   _| | ____ _ _ __  ";
            tutup[3] = " | __/ _ \\ '__| | '_ ` _ \\ / _` | | |/ / _` / __| | '_ \\  | __/ _ \\ |/ _` | '_ \\  | '_ ` _ \\ / _ \\ |/ _` | |/ / | | | |/ / _` | '_ \\ ";
            tutup[4] = " | ||  __/ |  | | | | | | | (_| | |   < (_| \\__ \\ | | | | | ||  __/ | (_| | | | | | | | | | |  __/ | (_| |   <| |_| |   < (_| | | | |";
            tutup[5] = "  \\__\\___|_|  |_|_| |_| |_|\\__,_| |_|\\_\\__,_|___/_|_| |_|  \\__\\___|_|\\__,_|_| |_| |_| |_| |_|\\___|_|\\__,_|_|\\_\\___,_|_|\\_\\__,_|_| |_|";

            string[] tutup2 = new string[8];
            tutup2[0] = "                                                           _   _ _        _   ";
            tutup2[1] = "                                                          | | (_) |      | |  ";
            tutup2[2] = "  _ __   ___ _ __ ___   ___  ___  __ _ _ __   __ _ _ __   | |_ _| | _____| |_ ";
            tutup2[3] = " | '_ \\ / _ \\ '_ ` _ \\ / _ \\/ __|/ _` | '_ \\ / _` | '_ \\  | __| | |/ / _ \\ __|";
            tutup2[4] = " | |_) |  __/ | | | | |  __/\\__ \\ (_| | | | | (_| | | | | | |_| |   <  __/ |_ ";
            tutup2[5] = " | .__/ \\___|_| |_| |_|\\___||___/\\__,_|_| |_|\\__,_|_| |_|  \\__|_|_|\\_\\___|\\__|";
            tutup2[6] = " | |                                                                          ";
            tutup2[7] = " |_|                                                                          ";

            int top = 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= 5; i++) {
                cursor(Console.WindowWidth / 2 - 70, top);
                foreach (char c in tutup[i]) {
                    Console.Write(c);
                }
                top++;
                Console.WriteLine("");
            }

            for (int i = 0; i <= 7; i++) {
                cursor(Console.WindowWidth / 2 - 45, top);
                foreach (char c in tutup2[i]) {
                    Console.Write(c);
                }
                top++;
                Console.WriteLine("");
            }
            Console.ResetColor();

        }
        static void menuexit(int hitung) {
            Console.ForegroundColor = ConsoleColor.Blue;
            string[] menu = new string[7];
            menu[0] = "  _                           ";
            menu[1] = " | |                          ";
            menu[2] = " | |__   ___  _ __ ___   ___  ";
            menu[3] = " | '_ \\ / _ \\| '_ ` _ \\ / _ \\ ";
            menu[4] = " | | | | (_) | | | | | |  __/ ";
            menu[5] = " |_| |_|\\___/|_| |_| |_|\\___| ";
            menu[6] = "                              ";

            string[] exit = new string[7];
            exit[0] = "            _ _    ";
            exit[1] = "           (_) |   ";
            exit[2] = "   _____  ___| |_  ";
            exit[3] = "  / _ \\ \\/ / | __| ";
            exit[4] = " |  __/>  <| | |_  ";
            exit[5] = "  \\___/_/\\_\\_|\\__| ";
            exit[6] = "                   ";

            int top = 32;

            for (int i = 0; i <= 6; i++) {
                if (hitung == 1) {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                cursor(Console.WindowWidth / 2 - 35, top);
                foreach (char a in menu[i]) {
                    Console.Write(a);
                }
                top++;
                Console.WriteLine("");
            }

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            top = 32;
            for (int i = 0; i <= 6; i++) {
                if (hitung == 2) {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                cursor(Console.WindowWidth / 2 + 10, top);
                foreach (char b in exit[i]) {
                    Console.Write(b);
                }
                top++;
                Console.WriteLine("");
            }
            Console.ResetColor();
        }

        static void gerbong(int[][,] arr, int start, int stop, string SedangDiBook) {
            int left, sisa = 0;
            if (stop - start == 1) {
                left = 48;
            } else {
                left = 18;
            }
            for (int x = start; x < stop; x++) {
                int top = 7;
                Console.SetCursorPosition(Console.WindowWidth / 7 + left, top);
                Console.WriteLine();
                string[] seat = new string[6];
                seat[0] = "";
                seat[1] = " HHHHHHHHH";
                seat[2] = " HHHHHHHHH";
                seat[3] = "                      ";
                seat[4] = " HHHHHHHHH";
                seat[5] = " HHHHHHHHH";

                int hitung = 0;
                char[][] jaggedArray = new char[5][];
                int a = 0;

                for (int i = 1; i <= 5; i++) {
                    jaggedArray[i - 1] = seat[i].ToCharArray();
                }


                for (int i = 0; i < arr[x].GetLength(0); i++) {
                    if (arr[x][i, 0] < 3 && arr[x][i, 0] > 0) {
                        jaggedArray[arr[x][i, 0] - 1][arr[x][i, 1]] = 'R';
                        sisa++;
                    } else if (arr[x][i, 0] >= 3) {
                        jaggedArray[arr[x][i, 0]][arr[x][i, 1]] = 'R';
                        sisa++;
                    }
                }

                if (SedangDiBook.Length > 0) {
                    if (SedangDiBook[0] - '0' < 3 && SedangDiBook[0] - '0' > 0) {
                        jaggedArray[(SedangDiBook[0] - '0') - 1][SedangDiBook[1] - '0'] = 'Y';
                    } else if (SedangDiBook[0] - '0' >= 3) {
                        jaggedArray[(SedangDiBook[0] - '0')][SedangDiBook[1] - '0'] = 'Y';
                    }
                }

                Console.SetCursorPosition(Console.WindowWidth / 7 + left, top + 1);
                Console.WriteLine("=====================");
                Console.SetCursorPosition(Console.WindowWidth / 7 + left - 1, top + 2);
                Console.WriteLine("/   1 2 3 4 5 6 7 8 9 \\");

                for (int i = 0; i < 5; i++) {
                    Console.SetCursorPosition(Console.WindowWidth / 7 + left - 2, top + 3);
                    if (i == 2) {
                        Console.Write("|");
                    } else {
                        if (i > 2) {
                            Console.Write($"|  {(char)('A' + i - 1)}");
                        } else {
                            Console.Write($"|  {(char)('A' + i)}");
                        }
                    }

                    for (int j = 0; j < jaggedArray[i].Length; j++) {
                        if (jaggedArray[i][j] == 'R') {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("■ ");
                        } else if (jaggedArray[i][j] == 'H') {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("■ ");
                        } else if (jaggedArray[i][j] == 'Y') {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("■ ");
                        } else {
                            Console.ResetColor();
                            Console.Write(jaggedArray[i][j]);
                        }
                        Console.ResetColor();

                    }
                    Console.Write(" |");
                    top++;
                    Console.WriteLine("");

                }
                Console.SetCursorPosition(Console.WindowWidth / 7 + left - 1, top + 3);
                Console.WriteLine("\\   1 2 3 4 5 6 7 8 9 /");
                Console.SetCursorPosition(Console.WindowWidth / 7 + left, top + 4);
                Console.WriteLine("=====================");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(Console.WindowWidth / 7 + left, top + 5);
                Console.WriteLine($"    Gerbong ke - {x + 1}\n");
                Console.ResetColor();
                left += 35;
            }
            cursor(Console.WindowWidth / 2 - 20, 23);
            Console.CursorVisible = false;
            Console.Write("Sisa Kursi Yang Tersedia = ");
            Console.ForegroundColor = ConsoleColor.Green;
            if (stop - start == 1) {
                Console.WriteLine($"{36 - sisa}\n");
            } else {
                Console.WriteLine($"{108 - sisa}\n");
            }
            Console.ResetColor();
        }

        public static string kal;
        static string cekjadwal() {
            Console.CursorVisible = true;
            bool cek = false;
            string cekdate, cektujuan, cekasal;
            cekdate = "";
            cektujuan = "";
            cekasal = "";
            do {
                cek = false;
                ConsoleKeyInfo tombol;
                char input;
                bool next = false;
                DateTime dt;
                do {
                    Console.SetCursorPosition(Console.WindowWidth / 2 + 12, 2);
                    Console.Write(cekdate);
                    tombol = Console.ReadKey(true);
                    input = tombol.KeyChar;
                    int hapus;
                    if (char.IsDigit(input) && cekdate.Length < 10) {
                        cekdate += input;
                        if (cekdate.Length == 2 || cekdate.Length == 5)
                            cekdate += '/';
                    } else if (tombol.Key == ConsoleKey.Backspace && cekdate.Length > 0) {
                        hapus = (Console.WindowWidth) / 2 + 12 + cekdate.Length - 1;
                        cekdate = cekdate.Remove(cekdate.Length - 1);
                        Console.SetCursorPosition(hapus, 2);
                        int pnjg = (Console.WindowWidth) / 2 + 12;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (hapus == pnjg || hapus == pnjg + 1)
                            Console.Write("D");
                        else if (hapus == pnjg + 2 || hapus == pnjg + 5)
                            Console.Write("/");
                        else if (hapus == pnjg + 3 || hapus == pnjg + 4)
                            Console.Write("M");
                        else
                            Console.Write("Y");
                        Console.ResetColor();
                    } else if (tombol.Key == ConsoleKey.DownArrow) {
                        do {
                            Console.SetCursorPosition(Console.WindowWidth / 2 + 12, 3);
                            Console.Write(cekasal.ToUpper());
                            tombol = Console.ReadKey(true);
                            input = tombol.KeyChar;
                            if ((char.IsLetter(input) || input == ' ') && cekasal.Length < 30) {
                                cekasal += input;
                            } else if (tombol.Key == ConsoleKey.Backspace && cekasal.Length > 0) {
                                hapus = (Console.WindowWidth) / 2 + 12 + cekasal.Length - 1;
                                cekasal = cekasal.Remove(cekasal.Length - 1);
                                Console.SetCursorPosition(hapus, 3);
                                Console.Write(" ");
                            } else if (tombol.Key == ConsoleKey.UpArrow) {
                                break;
                            } else if (tombol.Key == ConsoleKey.DownArrow) {
                                do {
                                    Console.ResetColor();
                                    Console.SetCursorPosition(Console.WindowWidth / 2 + 12, 4);
                                    Console.Write(cektujuan.ToUpper());
                                    tombol = Console.ReadKey(true);
                                    input = tombol.KeyChar;
                                    if ((char.IsLetter(input) || input == ' ') && cektujuan.Length < 30) {
                                        cektujuan += input;
                                    } else if (tombol.Key == ConsoleKey.Backspace && cektujuan.Length > 0) {
                                        hapus = (Console.WindowWidth) / 2 + 12 + cektujuan.Length - 1;
                                        cektujuan = cektujuan.Remove(cektujuan.Length - 1);
                                        Console.SetCursorPosition(hapus, 4);
                                        Console.Write(" ");
                                    } else if (tombol.Key == ConsoleKey.UpArrow) {
                                        break;
                                    } else if (tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.Enter) {
                                        do {
                                            Console.SetCursorPosition(Console.WindowWidth / 2, 5);
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("SUBMIT");
                                            tombol = Console.ReadKey(true);
                                            bool yes = false;
                                            if (tombol.Key == ConsoleKey.UpArrow)
                                                break;
                                            else if (tombol.Key == ConsoleKey.Enter) {
                                                if (!DateTime.TryParse(cekdate, out dt)) {
                                                    Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 2);
                                                    Console.Write("** TANGGAL TIDAK VALID **");
                                                } else {
                                                    var today = DateTime.Now;
                                                    var ourdate = DateTime.ParseExact(cekdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                                    if (ourdate <= today) {
                                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 2);
                                                        Console.Write("** TANGGAL TIDAK VALID **");
                                                    } else if (ourdate > today)
                                                        yes = true;
                                                }
                                                if (cekasal == "" || cektujuan == "" || !(DateTime.TryParse(cekdate, out dt)) ) {
                                                    if (cekasal == "") {
                                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 3);
                                                        Console.Write("** ASAL TIDAK VALID **");
                                                    }
                                                    if (cektujuan == "") {
                                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 4);
                                                        Console.Write("** TUJUAN TIDAK VALID **");
                                                    }
                                                    if (!DateTime.TryParse(cekdate, out dt)) {
                                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 2);
                                                        Console.Write("** TANGGAL TIDAK VALID **");
                                                    }
                                                }
                                                if (cekasal != "" && cektujuan != "" && yes) {
                                                    next = true;
                                                }
                                            }
                                            Console.ResetColor();
                                        } while (!next);
                                        
                                    }
                                    if (cektujuan.Length > 0) {
                                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 4);
                                        Console.Write("                        ");
                                    }
                                } while (!next);
                            }
                            if (cekasal.Length > 0) {
                                Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 3);
                                Console.Write("                      ");
                            }
                        } while (!next);
                    }
                    if (DateTime.TryParse(cekdate, out dt)) {
                        Console.SetCursorPosition(Console.WindowWidth / 2 + 40, 2);
                        Console.Write("                         ");
                    }
                } while (!next);
                cek = true;
            } while (!cek);
            string[] arr = new string[3];
            string temp = "";
            if (cek) {
                arr[0] = cekdate;
                arr[1] = cekasal;
                arr[2] = cektujuan;
            }
            for (int i = 0; i < 3; i++) {
                temp += arr[i];
                temp += '+';
            }
            return temp;
        }

        static string jadwal() {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 37, 0);
            Console.Write("Masukan Jadwal yang ingin Anda ketahui dengan mengisikan data berikut:");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 32, 2);
            Console.Write("Tanggal Keberangkatan yang ingin dicek\t: ");
            Console.SetCursorPosition(Console.WindowWidth / 2 + 12, 2);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("DD/MM/YYYY");
            Console.ResetColor();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 32, 3);
            Console.Write("Asal Keberangkatan\t\t\t: ");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 32, 4);
            Console.Write("Tujuan Keberangkatan\t\t\t: ");
            Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("SUBMIT");
            Console.ResetColor();
            return cekjadwal();
        }

        static void jadwal1(int k, int top2, string tglberangkat, string asalkota, string kotatujuan) {
            //pembuatan tiket untuk cek kodebooking
            // n => tinggi

            int n = 9;
            int m = 68;
            int sides2 = Console.WindowWidth / 2 - 35;
            int tmp = top2;
            for (int i = 0; i < n; i++) {
                cursor(sides2, top2);
                for (int j = 0; j < m; j++) {
                    if (i == 0 || i == n - 1) {
                        Console.Write("=");
                    } else if (j == 0 || j == m - 1) {
                        Console.Write("|");
                    } else {
                        Console.Write(" ");
                    }
                }
                top2++;
                Console.WriteLine("");
            }
            top2 = tmp;

            cursor(sides2 + 18, top2 + 1);
            Console.WriteLine("Jadwal Kereta Virtual Train");

            cursor(sides2 + 8, top2 + 3);
            Console.Write("{0,12:D} \t ==>> \t {1,12:D}", asalkota, kotatujuan);
            if (k == 0) {
                cursor(sides2 + 8, top2 + 5);
                Console.Write("berangkat : 08:00  \t\t tiba : 10:00 ");
                cursor(sides2 + 8, top2 + 7);
                Console.Write("Harga Tiket : Rp.24.000,-");
            } else if (k == 1) {
                cursor(sides2 + 8, top2 + 5);
                Console.Write("berangkat : 13:00  \t\t tiba : 15:00 ");
                cursor(sides2 + 8, top2 + 7);
                Console.Write("Harga Tiket : Rp.24.000,-");
            } else {
                cursor(sides2 + 8, top2 + 5);
                Console.Write("berangkat : 19:00  \t\t tiba : 21:00 ");
                cursor(sides2 + 8, top2 + 7);
                Console.Write("Harga Tiket : Rp.24.000,-");
            }

        }

        static void Main(string[] args) {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //maxsize windows
            MaxWindows();

        label:

            main();

            String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
            int numColors = colorNames.Length;

            ConsoleKeyInfo keyinfo;
            ConsoleKeyInfo keyInfoent;
            int cnt = 1;
            menu(cnt);
            Console.CursorVisible = false;

            do {
                keyinfo = Console.ReadKey(true);
                if (keyinfo.Key == ConsoleKey.Enter) {
                    Console.Clear();
                    break;
                }
                switch (keyinfo.Key) {
                    case ConsoleKey.UpArrow:
                        if (cnt == 2 || cnt == 3) cnt -= 1;
                        else cnt -= 0;
                        menu(cnt);
                        Console.CursorVisible = false;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cnt == 1 || cnt == 2) cnt += 1;
                        else cnt += 0;
                        menu(cnt);
                        Console.CursorVisible = false;
                        break;
                }
                if (Console.KeyAvailable) {
                    keyInfoent = Console.ReadKey(true);
                    if (keyInfoent.Key == ConsoleKey.Enter) {
                        Console.Clear();
                        break;
                    }
                }
            } while (true);

            if (cnt == 1) {
                tiket(6);

                int cnt1 = 1;
                menuexit(cnt1);
                Console.CursorVisible = false;

                do {
                    keyinfo = Console.ReadKey(true);
                    if (keyinfo.Key == ConsoleKey.Enter) {
                        Console.Clear();
                        break;
                    }
                    switch (keyinfo.Key) {
                        case ConsoleKey.LeftArrow:
                            if (cnt1 == 2) cnt1 -= 1;
                            else cnt -= 0;
                            menuexit(cnt1);
                            Console.CursorVisible = false;
                            break;
                        case ConsoleKey.RightArrow:
                            if (cnt1 == 1) cnt1 += 1;
                            else cnt += 0;
                            menuexit(cnt1);
                            Console.CursorVisible = false;
                            break;
                    }
                    if (Console.KeyAvailable) {
                        keyInfoent = Console.ReadKey(true);
                        if (keyInfoent.Key == ConsoleKey.Enter) {
                            Console.Clear();
                            break;
                        }
                    }
                } while (true);

                if (cnt1 == 1) {
                    goto label;
                } else {
                    Environment.Exit(0);
                }

            } else if (cnt == 2) {

                formulirawal form = new formulirawal();
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

                Console.CursorVisible = false;

                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < 10; i++) {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 40, i + 2);
                    for (int j = 0; j < 80; j++) {
                        if (i == 0 || i == 9)
                            Console.Write('=');
                        else if (j == 0 || j == 79)
                            Console.Write('|');
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(Console.WindowWidth / 2 - 2, 3);
                Console.Write("HELP");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 39, 5);
                Console.Write("1. Gunakan Tanda Panah ke bawah atau Enter untuk lanjut ke pengisian ");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 39, 6);
                Console.Write("   selanjutnya dan Tanda panah ke atas untuk kembali ke pengisian sebelumnya");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 39, 7);
                Console.Write("2. Gunakan Tanda panah ke Kanan atau ke Kiri untuk memilih waktu yang tersedia");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 39, 8);
                Console.Write("3. Jika pengisian data pada halaman ini telah selesai dilakukan, tekan enter");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 39, 9);
                Console.Write("   pada bagian SUBMIT untuk dilanjutkan ke halaman berikutnya");

                Console.ResetColor();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 30, Console.WindowHeight / 4 + 5);
                Console.Write("Silahkan lakukan pengisian data pada formulir dibawah ini ...");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 40, Console.WindowHeight / 4 + 8);
                Console.Write("Nama Lengkap\t\t\t\t: ");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 40, Console.WindowHeight / 4 + 9);
                Console.Write("Asal Kota Anda\t\t\t\t: ");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 40, Console.WindowHeight / 4 + 10);
                Console.Write("Tujuan Kota yang akan dikunjungi\t\t: ");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 40, Console.WindowHeight / 4 + 11);
                Console.Write("Tanggal Keberangkatan\t\t\t: ");
                Console.SetCursorPosition(Console.WindowWidth / 2 + 5, Console.WindowHeight / 4 + 11);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("DD/MM/YYYY");
                Console.ResetColor();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 40, Console.WindowHeight / 4 + 12);
                Console.Write("Waktu Keberangkatan\t\t\t: ");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 4 + 15);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("SUBMIT");
                Console.ResetColor();
                form.isidata();
                Console.CursorVisible = true;

                Console.Clear();

                form.cekgerbong();

                int[][,] jaggedArray = new int[3][,];
                jaggedArray[0] = new int[40, 2];
                jaggedArray[1] = new int[40, 2];
                jaggedArray[2] = new int[40, 2];

                string[,] result = form.cekgerbong();


                for (int i = countgerbong / 2; i < countgerbong; i++) {
                    
                    string temporary = result[i, 1];
                    jaggedArray[Int32.Parse(result[i, 0]) - 1][Int32.Parse((temporary[0] - 'A').ToString() + temporary[1].ToString()), 0] = temporary[0] - 'A' + 1;
                    jaggedArray[Int32.Parse(result[i, 0]) - 1][Int32.Parse((temporary[0] - 'A').ToString() + temporary[1].ToString()), 1] = temporary[1] - '0';
                }
                countgerbong = 0;
                string SedangDiBook = "";

                gerbong(jaggedArray, 0, 3, SedangDiBook);
                cursor(Console.WindowWidth / 2 - 20, 25);
                Console.CursorVisible = true;
                Console.Write("Silahkan Pilih Gerbong Anda : ");
                int temp = Convert.ToInt32(Console.ReadLine());
                int carriage = temp - 1;
                tempgerbong = temp;
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                gerbong(jaggedArray, carriage, carriage + 1, SedangDiBook);
                int kebenaran = 0;
                do {
                    cursor(Console.WindowWidth / 2 - 26, 25);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ■");
                    Console.ResetColor();
                    Console.Write(" Sudah Terisi    ");
                    cursor(Console.WindowWidth / 2 - 10, 25);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" ■");
                    Console.ResetColor();
                    Console.Write(" Yang Dipilih    ");
                    cursor(Console.WindowWidth / 2 + 8, 25);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("■");
                    Console.ResetColor();
                    Console.WriteLine(" Tersedia    \n");
                    cursor(Console.WindowWidth / 2 - 30, 27);
                    Console.CursorVisible = true;
                    Console.Write("Silahkan pilih tempat duduk Anda (format : RowColumn): ");
                    string seat = Console.ReadLine();
                    string tmptddk1 = seat.ToUpper();
                    tempatduduk = tmptddk1;


                    int cek = 1;
                    int cektmptddk = 0;
                    if (jaggedArray[carriage].GetLength(0) == 37) {
                        cursor(Console.WindowWidth / 2 - 30, 25);
                        Console.WriteLine("Maaf harap memilih waktu keberangkatan lainnya");
                    } else {
                        for (int i = 0; i < jaggedArray[carriage].GetLength(0); i++) {
                            if (jaggedArray[carriage][i, 0] == tmptddk1[0] - 'A' + 1 && jaggedArray[carriage][i, 1] == tmptddk1[1] - '0') {
                                cek = 0;
                                break;
                            } else if (i == jaggedArray[carriage].GetLength(0) - 1 && cek == 1) {
                                cektmptddk = 1;
                            }
                        }
                        if (cektmptddk == 1) {
                            jaggedArray[carriage][Int32.Parse((tmptddk1[0] - 'A').ToString() + tmptddk1[1].ToString()), 0] = tmptddk1[0] - 'A' + 1;
                            jaggedArray[carriage][Int32.Parse((tmptddk1[0] - 'A').ToString() + tmptddk1[1].ToString()), 1] = tmptddk1[1] - '0';

                            SedangDiBook += tmptddk1[0] - 'A' + 1;
                            SedangDiBook += tmptddk1[1] - '0';

                            kebenaran = 1;
                        }
                    }
                    Console.Clear();
                    if (cek == 0) {
                        cursor(Console.WindowWidth / 2 - 30, 28);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Maaf tempat duduk ini telah dipesan,mohon memilih yang lain");
                        
                    }
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 0);
                    gerbong(jaggedArray, carriage, carriage + 1, SedangDiBook);
                    tempnobook += nobook();
                    cursor(Console.WindowWidth / 2 - 30, 27);
                    Console.WriteLine($"Kode booking pemesanan tiket kereta api = {tempnobook}");
                    if (kebenaran == 1) {
                        cursor(Console.WindowWidth / 2 - 30, 29);
                        Console.WriteLine("Tiket kereta Api seharga Rp.24.000,-");
                        form.simpandata();
                        string semen = $"({form.date[0]}{form.date[1]})({form.date[3]}{form.date[4]})({form.date[6]}{form.date[7]}{form.date[8]}{form.date[9]})";
                        string tara = $"{form.time[0]}{form.time[1]}";
                        string namaFile = $"{form.asal}_{form.tujuan}_{semen}_{tara}.txt";
                        StreamWriter tulis = new StreamWriter(namaFile, true);
                        tulis.WriteLine($"{form.nama}, {tempgerbong}, {tempatduduk}, {tempnobook}");
                        tulis.Close();

                        tempnobook = "";
                    } else {
                        Console.Write("");
                    }
                    tempnobook = "";
                } while (kebenaran == 0);




                Console.ReadKey();


                Console.Clear();
                penutup();
                main2();
                Console.ResetColor();

                int cnt1 = 1;
                menuexit(cnt1);
                Console.CursorVisible = false;

                do {
                    keyinfo = Console.ReadKey(true);
                    if (keyinfo.Key == ConsoleKey.Enter) {
                        Console.Clear();
                        break;
                    }
                    switch (keyinfo.Key) {
                        case ConsoleKey.LeftArrow:
                            if (cnt1 == 2) cnt1 -= 1;
                            else cnt -= 0;
                            menuexit(cnt1);
                            Console.CursorVisible = false;
                            break;
                        case ConsoleKey.RightArrow:
                            if (cnt1 == 1) cnt1 += 1;
                            else cnt += 0;
                            menuexit(cnt1);
                            Console.CursorVisible = false;
                            break;
                    }
                    if (Console.KeyAvailable) {
                        keyInfoent = Console.ReadKey(true);
                        if (keyInfoent.Key == ConsoleKey.Enter) {
                            Console.Clear();
                            break;
                        }
                    }
                } while (true);

                if (cnt1 == 1) {
                    goto label;
                } else {
                    Environment.Exit(0);
                }


            } else {
                Console.ResetColor();

                kal = jadwal();
                string[] arr = new string[4];
                int idx1 = 0;
                string temp = "";
                for (int i = 0; i < kal.Length; i++) {
                    if (kal[i] != '+') {
                        temp += kal[i];
                    } else {
                        arr[idx1] = temp;
                        temp = "";
                        idx1 += 1;
                    }
                }
                //arr[idx1] = temp;

                int top2 = 5;
                for (int i = 0; i < 3; i++) {
                    jadwal1(i, top2, arr[0], arr[1], arr[2]);
                    top2 += 9;
                }

                int cnt1 = 1;
                menuexit(cnt1);
                Console.CursorVisible = false;

                do {
                    keyinfo = Console.ReadKey(true);
                    if (keyinfo.Key == ConsoleKey.Enter) {
                        Console.Clear();
                        break;
                    }
                    switch (keyinfo.Key) {
                        case ConsoleKey.LeftArrow:
                            if (cnt1 == 2) cnt1 -= 1;
                            else cnt -= 0;
                            menuexit(cnt1);
                            Console.CursorVisible = false;
                            break;
                        case ConsoleKey.RightArrow:
                            if (cnt1 == 1) cnt1 += 1;
                            else cnt += 0;
                            menuexit(cnt1);
                            Console.CursorVisible = false;
                            break;
                    }
                    if (Console.KeyAvailable) {
                        keyInfoent = Console.ReadKey(true);
                        if (keyInfoent.Key == ConsoleKey.Enter) {
                            Console.Clear();
                            break;
                        }
                    }
                } while (true);

                if (cnt1 == 1) {
                    goto label;
                } else {
                    Environment.Exit(0);
                }

            }
        }
    }
}
