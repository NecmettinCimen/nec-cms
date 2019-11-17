Locale.define('tr-TR', 'Date', {

    months: ['Ocak', 'Şubat', 'Mart', 'Nisan', 'Mayıs', 'Haziran', 'Temmuz', 'Ağustos', 'Eylül', 'Ekim', 'Kasım', 'Aralık'],
    months_abbr: ['Oca', 'Şub', 'Mar', 'Nis', 'May', 'Haz', 'Tem', 'Ağu', 'Eyl', 'Eki', 'Kas', 'Ara'],
    days: ['Pazar', 'Pazartesi', 'Salı', 'Çarşamba', 'Perşembe', 'Cuma', 'Cumartesi'],
    days_abbr: ['Paz', 'Pzt', 'Sal', 'Çar', 'Per', 'Cum', 'Cts'],

    // Culture's date order: MM/DD/YYYY
    dateOrder: ['date', 'month', 'year'],
    shortDate: '%d.%m.%Y',
    shortTime: '%I:%M%p',
    AM: 'AM',
    PM: 'PM',
    firstDayOfWeek: 1,

    // Date.Extras
    ordinal: function (dayOfMonth) {
        // 1st, 2nd, 3rd, etc.
        //return (dayOfMonth > 3 && dayOfMonth < 21) ? 'th' : ['th', 'st', 'nd', 'rd', 'th'][Math.min(dayOfMonth % 10, 4)];
        var son = (dayOfMonth % 10);
        if (dayOfMonth == 10 || son == 9) o = 'uncu';
        else if (son == 1 || son == 2 || son == 5 || son == 7 || son == 8) o = 'inci';
        else if (son == 3 || son == 4) o = 'üncü';
        else if (son == 6) o = 'ncı';
        return o;
    },

    lessThanMinuteAgo: 'less than a minute ago',
    minuteAgo: 'about a minute ago',
    minutesAgo: '{delta} minutes ago',
    hourAgo: 'about an hour ago',
    hoursAgo: 'about {delta} hours ago',
    dayAgo: '1 day ago',
    daysAgo: '{delta} days ago',
    weekAgo: '1 week ago',
    weeksAgo: '{delta} weeks ago',
    monthAgo: '1 month ago',
    monthsAgo: '{delta} months ago',
    yearAgo: '1 year ago',
    yearsAgo: '{delta} years ago',

    lessThanMinuteUntil: 'less than a minute from now',
    minuteUntil: 'about a minute from now',
    minutesUntil: '{delta} minutes from now',
    hourUntil: 'about an hour from now',
    hoursUntil: 'about {delta} hours from now',
    dayUntil: '1 day from now',
    daysUntil: '{delta} days from now',
    weekUntil: '1 week from now',
    weeksUntil: '{delta} weeks from now',
    monthUntil: '1 month from now',
    monthsUntil: '{delta} months from now',
    yearUntil: '1 year from now',
    yearsUntil: '{delta} years from now'

});


Locale.define('tr-TR', 'FormValidator', {

    required: 'Bu alan boş bırakılamaz.',
    length: 'Lütfen {length} karakter girin ({elLength} girdiniz)',
    minLength: 'En az {minLength} karakter girin ({length} girdiniz).',
    maxLength: 'En fazla{maxLength} karakter girin ({length} girdiniz).',
    integer: 'Lütfen bir tam sayı giriniz.',
    numeric: 'Lütfen sayısal bir değer girin.',
    digits: 'Lütfen sayısal giriş yapın (rakamlar, nokta ve tire kullanabilirsiniz).',
    alpha: 'Sadece harf (a-z) kullanın. Boşluk kullanmayın.',
    alphanum: 'Sadece harf (a-z) veya rakam (0-9) kullanın.',
    dateSuchAs: '{date} gibi bir tarih girin.',
    dateInFormatMDY: 'MM/DD/YYYY gibi geçerli bir tarih girin (ör: "12/31/1999")',
    email: 'Geçerli bir eposta adresi girin.',
    url: 'Geçerli bir web adresi girin. http://www.example.com gibi.',
    currencyDollar: 'Geçerli bir miktar $ girin. Ör: $100.00 .',
    oneRequired: 'En az birini girin.',

    // Form.Validator.Extras
    noSpace: 'Bu alanda boşluk olmamalı.',
    reqChkByNode: 'Hiç biri seçilmedi.',
    requiredChk: 'Bu alan gereklidir.',
    reqChkByName: 'Lütfen bir {label} girin.',
    match: 'Bu alan {matchName} alanı ile uymalıdır.',
    startDate: 'başlangıç tarihi',
    endDate: 'bitiş tarihi',
    currendDate: 'bugünün tarihi',
    afterDate: 'Tarih {label} ile aynı veya sonra olmalı.',
    beforeDate: 'Tarih {label} ile aynı veya önce olmalı.',
    startMonth: 'Başlangıç ayı seçin',
    sameMonth: 'Bu iki tarih aynı ay içerisinde olmalıdır.',
    creditcard: 'Geçerli bir kredikartı numarası girin.',
    errorPrefix: 'Hata:',
    warningPrefix: 'Uyarı: '

});

Locale.define('tr-TR', 'Number', {

    decimal: ',',
    group: '.',

    /* 	Commented properties are the defaults for Number.format
     decimals: 0,
     precision: 0,
     scientific: null,

     prefix: null,
     suffic: null,

     // Negative/Currency/percentage will mixin Number
     negative: {
     prefix: '-'
     },*/

    currency: {
//		decimals: 2,
        prefix: '$ '
    }/*,

     percentage: {
     decimals: 2,
     suffix: '%'
     }*/

});



