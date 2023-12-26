﻿namespace QuranApp.Models
{
    public class Edition
    {
        public string Identifier { get; set; }

        public string Language { get; set; }

        public string Name { get; set; }

        public string EnglishName { get; set; }

        public string Direction { get; set; }

        public string Type { get; set; }

        public string Format { get; set; }
    }
}


// Text format

/*
{
  "code": 200,
  "status": "OK",
  "data": [
    {
      "identifier": "ar.muyassar",
      "language": "ar",
      "name": "تفسير المیسر",
      "englishName": "King Fahad Quran Complex",
      "format": "text",
      "type": "tafsir",
      "direction": "rtl"
    },
    {
      "identifier": "az.mammadaliyev",
      "language": "az",
      "name": "Məmmədəliyev & Bünyadov",
      "englishName": "Vasim Mammadaliyev and Ziya Bunyadov",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "az.musayev",
      "language": "az",
      "name": "Musayev",
      "englishName": "Alikhan Musayev",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "bn.bengali",
      "language": "bn",
      "name": "মুহিউদ্দীন খান",
      "englishName": "Muhiuddin Khan",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "cs.hrbek",
      "language": "cs",
      "name": "Hrbek",
      "englishName": "Preklad I. Hrbek",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "cs.nykl",
      "language": "cs",
      "name": "Nykl",
      "englishName": "A. R. Nykl",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "de.aburida",
      "language": "de",
      "name": "Abu Rida",
      "englishName": "Abu Rida Muhammad ibn Ahmad ibn Rassoul",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "de.bubenheim",
      "language": "de",
      "name": "Bubenheim & Elyas",
      "englishName": "A. S. F. Bubenheim and N. Elyas",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "de.khoury",
      "language": "de",
      "name": "Khoury",
      "englishName": "Adel Theodor Khoury",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "de.zaidan",
      "language": "de",
      "name": "Zaidan",
      "englishName": "Amir Zaidan",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "dv.divehi",
      "language": "dv",
      "name": "ދިވެހި",
      "englishName": "Office of the President of Maldives",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "en.ahmedali",
      "language": "en",
      "name": "Ahmed Ali",
      "englishName": "Ahmed Ali",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.ahmedraza",
      "language": "en",
      "name": "Ahmed Raza Khan",
      "englishName": "Ahmed Raza Khan",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.arberry",
      "language": "en",
      "name": "Arberry",
      "englishName": "A. J. Arberry",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.asad",
      "language": "en",
      "name": "Asad",
      "englishName": "Muhammad Asad",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.daryabadi",
      "language": "en",
      "name": "Daryabadi",
      "englishName": "Abdul Majid Daryabadi",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.hilali",
      "language": "en",
      "name": "Hilali & Khan",
      "englishName": "Muhammad Taqi-ud-Din al-Hilali and Muhammad Muhsin Khan",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.pickthall",
      "language": "en",
      "name": "Pickthall",
      "englishName": "Mohammed Marmaduke William Pickthall",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.qaribullah",
      "language": "en",
      "name": "Qaribullah & Darwish",
      "englishName": "Hasan al-Fatih Qaribullah and Ahmad Darwish",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.sahih",
      "language": "en",
      "name": "Saheeh International",
      "englishName": "Saheeh International",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.sarwar",
      "language": "en",
      "name": "Sarwar",
      "englishName": "Muhammad Sarwar",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.yusufali",
      "language": "en",
      "name": "Yusuf Ali",
      "englishName": "Abdullah Yusuf Ali",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "fa.ayati",
      "language": "fa",
      "name": "آیتی",
      "englishName": "AbdolMohammad Ayati",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.fooladvand",
      "language": "fa",
      "name": "فولادوند",
      "englishName": "Mohammad Mahdi Fooladvand",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.ghomshei",
      "language": "fa",
      "name": "الهی قمشه‌ای",
      "englishName": "Mahdi Elahi Ghomshei",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.makarem",
      "language": "fa",
      "name": "مکارم شیرازی",
      "englishName": "Naser Makarem Shirazi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fr.hamidullah",
      "language": "fr",
      "name": "Hamidullah",
      "englishName": "Muhammad Hamidullah",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ha.gumi",
      "language": "ha",
      "name": "Gumi",
      "englishName": "Abubakar Mahmoud Gumi",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "hi.hindi",
      "language": "hi",
      "name": "फ़ारूक़ ख़ान & नदवी",
      "englishName": "Suhel Farooq Khan and Saifur Rahman Nadwi",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "id.indonesian",
      "language": "id",
      "name": "Bahasa Indonesia",
      "englishName": "Unknown",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "it.piccardo",
      "language": "it",
      "name": "Piccardo",
      "englishName": "Hamza Roberto Piccardo",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ja.japanese",
      "language": "ja",
      "name": "Japanese",
      "englishName": "Unknown",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ko.korean",
      "language": "ko",
      "name": "Korean",
      "englishName": "Unknown",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ku.asan",
      "language": "ku",
      "name": "ته‌فسیری ئاسان",
      "englishName": "Burhan Muhammad-Amin",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ml.abdulhameed",
      "language": "ml",
      "name": "അബ്ദുല്‍ ഹമീദ് & പറപ്പൂര്‍",
      "englishName": "Cheriyamundam Abdul Hameed and Kunhi Mohammed Parappoor",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "nl.keyzer",
      "language": "nl",
      "name": "Keyzer",
      "englishName": "Salomo Keyzer",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "no.berg",
      "language": "no",
      "name": "Einar Berg",
      "englishName": "Einar Berg",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "pl.bielawskiego",
      "language": "pl",
      "name": "Bielawskiego",
      "englishName": "Józefa Bielawskiego",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "pt.elhayek",
      "language": "pt",
      "name": "El-Hayek",
      "englishName": "Samir El-Hayek",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ro.grigore",
      "language": "ro",
      "name": "Grigore",
      "englishName": "George Grigore",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.kuliev",
      "language": "ru",
      "name": "Кулиев",
      "englishName": "Elmir Kuliev",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.osmanov",
      "language": "ru",
      "name": "Османов",
      "englishName": "Magomed-Nuri Osmanovich Osmanov",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.porokhova",
      "language": "ru",
      "name": "Порохова",
      "englishName": "V. Porokhova",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "sd.amroti",
      "language": "sd",
      "name": "امروٽي",
      "englishName": "Taj Mehmood Amroti",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "so.abduh",
      "language": "so",
      "name": "Abduh",
      "englishName": "Mahmud Muhammad Abduh",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "sq.ahmeti",
      "language": "sq",
      "name": "Sherif Ahmeti",
      "englishName": "Sherif Ahmeti",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "sq.mehdiu",
      "language": "sq",
      "name": "Feti Mehdiu",
      "englishName": "Feti Mehdiu",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "sq.nahi",
      "language": "sq",
      "name": "Efendi Nahi",
      "englishName": "Hasan Efendi Nahi",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "sv.bernstrom",
      "language": "sv",
      "name": "Bernström",
      "englishName": "Knut Bernström",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "sw.barwani",
      "language": "sw",
      "name": "Al-Barwani",
      "englishName": "Ali Muhsin Al-Barwani",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ta.tamil",
      "language": "ta",
      "name": "ஜான் டிரஸ்ட்",
      "englishName": "Jan Turst Foundation",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tg.ayati",
      "language": "tg",
      "name": "Оятӣ",
      "englishName": "AbdolMohammad Ayati",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "th.thai",
      "language": "th",
      "name": "ภาษาไทย",
      "englishName": "King Fahad Quran Complex",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.ates",
      "language": "tr",
      "name": "Süleyman Ateş",
      "englishName": "Suleyman Ates",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.bulac",
      "language": "tr",
      "name": "Alİ Bulaç",
      "englishName": "Alİ Bulaç",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.diyanet",
      "language": "tr",
      "name": "Diyanet İşleri",
      "englishName": "Diyanet Isleri",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.golpinarli",
      "language": "tr",
      "name": "Abdulbakî Gölpınarlı",
      "englishName": "Abdulbaki Golpinarli",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.ozturk",
      "language": "tr",
      "name": "Öztürk",
      "englishName": "Yasar Nuri Ozturk",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.transliteration",
      "language": "tr",
      "name": "Çeviriyazı",
      "englishName": "Muhammet Abay",
      "format": "text",
      "type": "transliteration",
      "direction": "ltr"
    },
    {
      "identifier": "tr.vakfi",
      "language": "tr",
      "name": "Diyanet Vakfı",
      "englishName": "Diyanet Vakfi",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.yazir",
      "language": "tr",
      "name": "Elmalılı Hamdi Yazır",
      "englishName": "Elmalili Hamdi Yazir",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.yildirim",
      "language": "tr",
      "name": "Suat Yıldırım",
      "englishName": "Suat Yildirim",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tr.yuksel",
      "language": "tr",
      "name": "Edip Yüksel",
      "englishName": "Edip Yüksel",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "tt.nugman",
      "language": "tt",
      "name": "Yakub Ibn Nugman",
      "englishName": "Yakub Ibn Nugman",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ug.saleh",
      "language": "ug",
      "name": "محمد صالح",
      "englishName": "Muhammad Saleh",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ur.ahmedali",
      "language": "ur",
      "name": "احمد علی",
      "englishName": "Ahmed Ali",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ur.jalandhry",
      "language": "ur",
      "name": "جالندہری",
      "englishName": "Fateh Muhammad Jalandhry",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ur.jawadi",
      "language": "ur",
      "name": "علامہ جوادی",
      "englishName": "Syed Zeeshan Haider Jawadi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ur.kanzuliman",
      "language": "ur",
      "name": "احمد رضا خان",
      "englishName": "Ahmed Raza Khan",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ur.qadri",
      "language": "ur",
      "name": "طاہر القادری",
      "englishName": "Tahir ul Qadri",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "uz.sodik",
      "language": "uz",
      "name": "Мухаммад Содик",
      "englishName": "Muhammad Sodik Muhammad Yusuf",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.maududi",
      "language": "en",
      "name": "Maududi",
      "englishName": "Abul Ala Maududi",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.shakir",
      "language": "en",
      "name": "Shakir",
      "englishName": "Mohammad Habib Shakir",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.transliteration",
      "language": "en",
      "name": "Transliteration",
      "englishName": "English Transliteration",
      "format": "text",
      "type": "transliteration",
      "direction": "ltr"
    },
    {
      "identifier": "es.cortes",
      "language": "es",
      "name": "Cortes",
      "englishName": "Julio Cortes",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "fa.ansarian",
      "language": "fa",
      "name": "انصاریان",
      "englishName": "Hussain Ansarian",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "quran-simple",
      "language": "ar",
      "name": "القرآن الكريم المبسط (تشكيل بسيط)",
      "englishName": "Simple",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-simple-clean",
      "language": "ar",
      "name": "القرآن الكريم المبسط (بدون تشكيل)",
      "englishName": "Simple Clean",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-simple-enhanced",
      "language": "ar",
      "name": "القرآن الكريم المبسط (بدون تشكيل)",
      "englishName": "Simple Enhanced",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-simple-min",
      "language": "ar",
      "name": "القرآن الكريم المبسط (بدون تشكيل)",
      "englishName": "Simple Minimal",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-uthmani-min",
      "language": "ar",
      "name": "القرآن الكريم برسم العثماني (تشكيل بسيط)",
      "englishName": "Uthmani Minimal",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-uthmani",
      "language": "ar",
      "name": "القرآن الكريم برسم العثماني",
      "englishName": "Uthmani",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "bg.theophanov",
      "language": "bg",
      "name": "Теофанов",
      "englishName": "Tzvetan Theophanov",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "bs.mlivo",
      "language": "bs",
      "name": "Mlivo",
      "englishName": "Mustafa Mlivo",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "fa.bahrampour",
      "language": "fa",
      "name": "بهرام پور",
      "englishName": "Abolfazl Bahrampour",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "es.asad",
      "language": "es",
      "name": "Asad",
      "englishName": "Muhammad Asad - Abdurrasak Pérez",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "fa.khorramshahi",
      "language": "fa",
      "name": "خرمشاهی",
      "englishName": "Baha'oddin Khorramshahi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.mojtabavi",
      "language": "fa",
      "name": "مجتبوی",
      "englishName": "Sayyed Jalaloddin Mojtabavi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "hi.farooq",
      "language": "hi",
      "name": "फ़ारूक़ ख़ान & अहमद",
      "englishName": "Muhammad Farooq Khan and Muhammad Ahmed",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "id.muntakhab",
      "language": "id",
      "name": "Quraish Shihab",
      "englishName": "Muhammad Quraish Shihab et al.",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ms.basmeih",
      "language": "ms",
      "name": "Basmeih",
      "englishName": "Abdullah Muhammad Basmeih",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.abuadel",
      "language": "ru",
      "name": "Абу Адель",
      "englishName": "Abu Adel",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.krachkovsky",
      "language": "ru",
      "name": "Крачковский",
      "englishName": "Ignaty Yulianovich Krachkovsky",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.muntahab",
      "language": "ru",
      "name": "Аль-Мунтахаб",
      "englishName": "Ministry of Awqaf, Egypt",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ru.sablukov",
      "language": "ru",
      "name": "Саблуков",
      "englishName": "Gordy Semyonovich Sablukov",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ur.junagarhi",
      "language": "ur",
      "name": "محمد جوناگڑھی",
      "englishName": "Muhammad Junagarhi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ur.maududi",
      "language": "ur",
      "name": "ابوالاعلی مودودی",
      "englishName": "Abul A'ala Maududi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "zh.jian",
      "language": "zh",
      "name": "Ma Jian",
      "englishName": "Ma Jian",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "zh.majian",
      "language": "zh",
      "name": "Ma Jian (Traditional)",
      "englishName": "Ma Jian",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "fa.khorramdel",
      "language": "fa",
      "name": "خرمدل",
      "englishName": "Mostafa Khorramdel",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.moezzi",
      "language": "fa",
      "name": "معزی",
      "englishName": "Mohammad Kazem Moezzi",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "bs.korkut",
      "language": "bs",
      "name": "Korkut",
      "englishName": "Besim Korkut",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ar.jalalayn",
      "language": "ar",
      "name": "تفسير الجلالين",
      "englishName": "Jalal ad-Din al-Mahalli and Jalal ad-Din as-Suyuti",
      "format": "text",
      "type": "tafsir",
      "direction": "rtl"
    },
    {
      "identifier": "quran-tajweed",
      "language": "ar",
      "name": "القرآن الكريم المجود (ملون)",
      "englishName": "Tajweed",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-wordbyword",
      "language": "ar",
      "name": "معاني مفردات القرآن",
      "englishName": "Word By Word",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-kids",
      "language": "ar",
      "name": "القرآن الكريم للأطفال",
      "englishName": "Kids",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-corpus-qd",
      "language": "ar",
      "name": "Corpus",
      "englishName": "Corpus",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "si.naseemismail",
      "language": "si",
      "name": "Naseem Ismail",
      "englishName": "Naseem Isamil and Masoor Maulana, Kaleel",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "quran-buck",
      "language": "ar",
      "name": "Buck",
      "englishName": "Buck",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "zh.mazhonggang",
      "language": "zh",
      "name": "Ma Zhong Gang",
      "englishName": "马仲刚",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "quran-wordbyword-2",
      "language": "ar",
      "name": "معاني مفردات القرآن ولفظها",
      "englishName": "Word by Word Transaltion by Dr. Shehnaz Shaikh",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-unicode",
      "language": "ar",
      "name": "القرآن الكريم برسم العثماني",
      "englishName": "Unicode Quran text from Khaled Hosny",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "quran-uthmani-quran-academy",
      "language": "ar",
      "name": "القرآن الكريم برسم العثماني",
      "englishName": "Modified Quran Uthmani Text from the Quran Academy to work with the Kitab font",
      "format": "text",
      "type": "quran",
      "direction": "rtl"
    },
    {
      "identifier": "ba.mehanovic",
      "language": "ba",
      "name": "Kur'an - sa prevodom (značenja) na bosanski jezik, utemeljen na Ibn Kesirovom tumačenju, i kratki komentar",
      "englishName": "Quran translation by Muhamed Mehanovic",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.itani",
      "language": "en",
      "name": "Clear Qur'an - Talal Itani",
      "englishName": "Clear Qur'an by Talal Itani",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ar.qurtubi",
      "language": "ar",
      "name": "تفسير القرطبي",
      "englishName": "Tafseer Al Qurtubi",
      "format": "text",
      "type": "tafsir",
      "direction": "rtl"
    },
    {
      "identifier": "ar.miqbas",
      "language": "ar",
      "name": "تنوير المقباس من تفسير بن عباس",
      "englishName": "Tafseer Tanwir al-Miqbas",
      "format": "text",
      "type": "tafsir",
      "direction": "rtl"
    },
    {
      "identifier": "ar.waseet",
      "language": "ar",
      "name": "الـتـفـسـيـر الـوسـيـط",
      "englishName": "Tafseer Al-Waseet",
      "format": "text",
      "type": "tafsir",
      "direction": "rtl"
    },
    {
      "identifier": "ar.baghawi",
      "language": "ar",
      "name": "تفسير البغوي",
      "englishName": "Tafseer Al-Baghawi",
      "format": "text",
      "type": "tafsir",
      "direction": "rtl"
    },
    {
      "identifier": "my.ghazi",
      "language": "my",
      "name": "Ghazi Muhammed Hashim",
      "englishName": "Translation by Ghazi Muhammed Hashim",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.mubarakpuri",
      "language": "en",
      "name": "Mubarakpuri",
      "englishName": "Mubarakpuri",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "am.sadiq",
      "language": "am",
      "name": "ሳዲቅ & ሳኒ ሐቢብ",
      "englishName": "ሳዲቅ & ሳኒ ሐቢብ",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ber.mensur",
      "language": "ber",
      "name": "At Mensur",
      "englishName": "At Mensur",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "bn.hoque",
      "language": "bn",
      "name": "জহুরুল হক",
      "englishName": "জহুরুল হক",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.qarai",
      "language": "en",
      "name": "Qarai",
      "englishName": "Qarai",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "en.wahiduddin",
      "language": "en",
      "name": "Wahiduddin Khan",
      "englishName": "Wahiduddin Khan",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "es.bornez",
      "language": "es",
      "name": "Bornez",
      "englishName": "Bornez",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "es.garcia",
      "language": "es",
      "name": "Garcia",
      "englishName": "Garcia",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ur.najafi",
      "language": "ur",
      "name": "محمد حسین نجفی",
      "englishName": "محمد حسین نجفی",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.gharaati",
      "language": "fa",
      "name": "قرائتی",
      "englishName": "قرائتی",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.sadeqi",
      "language": "fa",
      "name": "صادقی تهرانی",
      "englishName": "صادقی تهرانی",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "fa.safavi",
      "language": "fa",
      "name": "صفوی",
      "englishName": "صفوی",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "id.jalalayn",
      "language": "id",
      "name": "Tafsir Jalalayn",
      "englishName": "Tafsir Jalalayn",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ml.karakunnu",
      "language": "ml",
      "name": "കാരകുന്ന് & എളയാവൂര്",
      "englishName": "കാരകുന്ന് & എളയാവൂര്",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "nl.leemhuis",
      "language": "nl",
      "name": "Leemhuis",
      "englishName": "Leemhuis",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "nl.siregar",
      "language": "nl",
      "name": "Siregar",
      "englishName": "Siregar",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    },
    {
      "identifier": "ps.abdulwali",
      "language": "ps",
      "name": "عبدالولي",
      "englishName": "عبدالولي",
      "format": "text",
      "type": "translation",
      "direction": "rtl"
    },
    {
      "identifier": "ru.kuliev-alsaadi",
      "language": "ru",
      "name": "Кулиев + ас-Саади",
      "englishName": "Кулиев + ас-Саади",
      "format": "text",
      "type": "translation",
      "direction": "ltr"
    }
  ]
}
 */

// Audio format

/*
{
  "code": 200,
  "status": "OK",
  "data": [
    {
      "identifier": "ar.abdulbasitmurattal",
      "language": "ar",
      "name": "عبد الباسط عبد الصمد المرتل",
      "englishName": "Abdul Basit",
      "format": "audio",
      "type": "translation",
      "direction": null
    },
    {
      "identifier": "ar.abdullahbasfar",
      "language": "ar",
      "name": "عبد الله بصفر",
      "englishName": "Abdullah Basfar",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.abdurrahmaansudais",
      "language": "ar",
      "name": "عبدالرحمن السديس",
      "englishName": "Abdurrahmaan As-Sudais",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.abdulsamad",
      "language": "ar",
      "name": "عبدالباسط عبدالصمد",
      "englishName": "Abdul Samad",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.shaatree",
      "language": "ar",
      "name": "أبو بكر الشاطري",
      "englishName": "Abu Bakr Ash-Shaatree",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.ahmedajamy",
      "language": "ar",
      "name": "أحمد بن علي العجمي",
      "englishName": "Ahmed ibn Ali al-Ajamy",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.alafasy",
      "language": "ar",
      "name": "مشاري العفاسي",
      "englishName": "Alafasy",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.hanirifai",
      "language": "ar",
      "name": "هاني الرفاعي",
      "englishName": "Hani Rifai",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.husary",
      "language": "ar",
      "name": "محمود خليل الحصري",
      "englishName": "Husary",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.husarymujawwad",
      "language": "ar",
      "name": "محمود خليل الحصري (المجود)",
      "englishName": "Husary (Mujawwad)",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.hudhaify",
      "language": "ar",
      "name": "علي بن عبدالرحمن الحذيفي",
      "englishName": "Hudhaify",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.ibrahimakhbar",
      "language": "ar",
      "name": "إبراهيم الأخضر",
      "englishName": "Ibrahim Akhdar",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.mahermuaiqly",
      "language": "ar",
      "name": "ماهر المعيقلي",
      "englishName": "Maher Al Muaiqly",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.minshawi",
      "language": "ar",
      "name": "محمد صديق المنشاوي",
      "englishName": "Minshawi",
      "format": "audio",
      "type": "translation",
      "direction": null
    },
    {
      "identifier": "ar.minshawimujawwad",
      "language": "ar",
      "name": "محمد صديق المنشاوي (المجود)",
      "englishName": "Minshawy (Mujawwad)",
      "format": "audio",
      "type": "translation",
      "direction": null
    },
    {
      "identifier": "ar.muhammadayyoub",
      "language": "ar",
      "name": "محمد أيوب",
      "englishName": "Muhammad Ayyoub",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.muhammadjibreel",
      "language": "ar",
      "name": "محمد جبريل",
      "englishName": "Muhammad Jibreel",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.saoodshuraym",
      "language": "ar",
      "name": "سعود الشريم",
      "englishName": "Saood bin Ibraaheem Ash-Shuraym",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "en.walk",
      "language": "en",
      "name": "Ibrahim Walk",
      "englishName": "Ibrahim Walk",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "fa.hedayatfarfooladvand",
      "language": "fa",
      "name": "Fooladvand - Hedayatfar",
      "englishName": "Fooladvand - Hedayatfar",
      "format": "audio",
      "type": "translation",
      "direction": null
    },
    {
      "identifier": "ar.parhizgar",
      "language": "ar",
      "name": "شهریار پرهیزگار",
      "englishName": "Parhizgar",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ur.khan",
      "language": "ur",
      "name": "Shamshad Ali Khan",
      "englishName": "Shamshad Ali Khan",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "zh.chinese",
      "language": "zh",
      "name": "中文",
      "englishName": "Chinese",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "fr.leclerc",
      "language": "fr",
      "name": "Youssouf Leclerc",
      "englishName": "Youssouf Leclerc",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ar.aymanswoaid",
      "language": "ar",
      "name": "أيمن سويد",
      "englishName": "Ayman Sowaid",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    },
    {
      "identifier": "ru.kuliev-audio",
      "language": "ru",
      "name": "Elmir Kuliev by 1MuslimApp",
      "englishName": "Elmir Kuliev by 1MuslimApp",
      "format": "audio",
      "type": "versebyverse",
      "direction": null
    }
  ]
}
 */
