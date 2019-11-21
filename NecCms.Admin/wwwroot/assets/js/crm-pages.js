let pages = [
    {
        "parentname": `İçerik Yönetimi`,
        url: `/Icerik/Liste`,
        name: 'İçerik Listesi',
        tableurl: '/Icerik/IcerikListesi/',
        formPageUrl: '/Icerik/Ekle',
        customeditbutton: `<a class="btn btn-outline-warning btn-sm btn-pill" href="/Icerik/Duzenle/#id#"><i class="fa fa-edit"></i>Düzenle</a>`,
        silurl: '/Icerik/Kaldir',
        columns: [
            {
                title: "No",
                data: 'id'
            },
            {
                title: "Başlık",
                data: 'baslik'
            },
            {
                title: 'Menu',
                data: 'menu',
                render: (data) => `<a class="btn btn-outline-warning btn-sm btn-pill">${data}</a>`
            },
            {
                title: 'Durum',
                data: 'durum',
                render: (data, a, row) => `<button type="button" data-toggle="modal" onclick="durumDegistir(${row.id})" class="btn btn-outline-${data === 1 ? 'info' : 'danger'} btn-sm btn-pill">${data === 1 ? '<i class="fa fa-share"></i> Yayınla' : '<i class="fa fa-times"></i> Yayından Kaldır'}</button>`
            },
            {
                title: 'Kaldır',
                data: 'id',
                render: (data) =>  `<button class="btn btn-danger btn-sm btn-pill" data-toggle="modal" onclick="tid=${data};silitem()" type="button"><i class="fa fa-trash"></i> Kaldır</button>`
            }
        ]
    }, {
        url: '/Tema/Yonetim',
        parentname: 'Tema',
        name: 'Tema Yönetimi',
        tableurl: '/Tema/ParametreListesi/',
        saveurl: '/Tema/ParametreKaydet',
        silurl: '/Tema/ParametreKaldir',
        columns: [
            {title: "No", data: 'id'},
            {title: "Kodu", data: 'kodu'},
            {title: "İsim", data: 'isim'},
            {
                title: "Tip",
                data: 'tip',
                render: (data) => `<button disabled class="btn btn-outline-info">${["", "Yazı", "Dosya", "HTML"][data]}</button>`
            },
        ],
        form: [
            {type: 'input', id: 'kodu', name: 'Kodu'},
            {type: 'input', id: 'isim', name: 'İsim'},
            {type: 'textarea', id: 'aciklama', name: 'Açıklama'},
            {
                type: 'select',
                id: 'tip',
                name: 'Tip',
                data: [{text: 'Yazı', id: 1}, {text: 'Dosya', id: 2}, {text: 'HTML', id: 3}],
                style: 'width: 100%;float: left;margin-left: 5px;',
                required: true,
            },
        ]
    }, {
        url: '/Tema/Duzenle',
        parentname: 'Tema',
        name: 'Tema Düzenle',
        tableurl: '/Tema/ParametreDegerListesi/',
        customeditbutton: `<button type="button" onclick="duzenleForm(#id#)" class="btn btn-outline-warning btn-sm btn-pill"><i class="fa fa-edit"></i>Düzenle</button>`,
        saveurl: '/Tema/ParametreDegeriKaydet',
        formsubmittype: 'formdata',
        columns: [
            {title: "No", data: 'id'},
            {title: "Kodu", data: 'kodu'},
            {title: "İsim", data: 'isim'},
            {
                title: "Durum",
                data: 'durum',
                render: (data) => "<button class='btn btn-outline-" + (data ? 'success' : 'danger') + "'>" + (data ? 'Veri var' : 'Veri yok') + "</button>"
            },
        ]
    },{
        url: '/Iletisim',
        parentname: 'İletişim',
        name: 'Gelen Kutusu',
        tableurl: '/Iletisim/List/',
        customeditbutton: "<button disabled class='btn btn-outline-dark'>#id#</button>",
        columns: [
            {title: "Tarih", data: 'tarih', render:(data)=>formatDateLocate(data)},
            {title: "Konu", data: 'konu'},
            {title: "Ad Soyad", data: 'adSoyad'},
            {title: "Eposta", data: 'eposta'},
            {title: "Açıklama", data: 'aciklama'},
        ]
    },
];