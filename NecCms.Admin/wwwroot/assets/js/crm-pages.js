var pages = [{
    url: '/Icerik/Kategoriler',
    parentname: 'İçerik Yönetimi',
    name: 'İçerik Kategorileri',
    tableurl: '/Icerik/KategoriListesi/',
    saveurl: '/Icerik/KategoriKaydet',
    silurl: '/Icerik/KategoriSil',
    columns: [
        {
            title: "İsim",
            data: 'isim'
        }],
    form: [
        {
            type: 'select',
            id: 'ustKategoriId',
            name: 'Üst İçerik Kategorisi',
            ajax: '/Icerik/KategoriListesi',
            text: 'isim',
            style: 'width: 100%;float: left;margin-left: 5px;',
        }, {
            type: 'input',
            id: 'isim',
            name: 'İsim',
            maxLength: 50
        }]
},
{
    url: '/Icerik/Liste',
    parentname: 'İçerik Yönetimi',
    name: 'İçerik Listesi',
    tableurl: '/Icerik/IcerikListesi/',
    formPageUrl: '/Icerik/Ekle',
    customeditbutton: `<a href="/Icerik/Duzenle/#id#"` +
        ` class="btn btn-outline-warning btn-sm btn-pill">` +
        `<i class="fa fa-edit"></i>Düzenle</a>`,
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
            title: 'Durum',
            data: 'durum',
            render: (data, a, row) => `<button type="button" data-toggle="modal" onclick="durumDegistir(${row.id})"` +
                ` class="btn btn-outline-${data == 1 ? 'info' : 'danger'} btn-sm btn-pill">` +
                `${data == 1 ? '<i class="fa fa-share"></i> Yayınla' : '<i class="fa fa-times"></i> Yayından Kaldır'}</button>`
        },
        {
            title: 'Kaldır',
            data: 'id',
            render: (data) => `<button type="button" data-toggle="modal" onclick="tid=${data};silitem()"` +
                ` class="btn btn-danger btn-sm btn-pill">` +
                `<i class="fa fa-trash"></i> Kaldır</button>`
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
        { title: "No", data: 'id' },
        { title: "Kodu", data: 'kodu' },
        { title: "İsim", data: 'isim' },
        { title: "Tip", data: 'tip', render: (data) => `<button disabled class="btn btn-outline-info">${["", "Yazı", "Dosya", "Resim"][data]}</button>` },
    ],
    form: [
        { type: 'input', id: 'kodu', name: 'Kodu' },
        { type: 'input', id: 'isim', name: 'İsim' },
        { type: 'textarea', id: 'aciklama', name: 'Açıklama' },
        {
            type: 'select',
            id: 'tip',
            name: 'Tip',
            data: [{ text: 'Yazı', id: 1 }, { text: 'Dosya', id: 2 }, { text: 'HTML', id: 3 }],
            style: 'width: 100%;float: left;margin-left: 5px;',
            required: true,
        },
    ]
}, {
    url: '/Tema/Duzenle',
    parentname: 'Tema',
    name: 'Tema Düzenle',
    tableurl: '/Tema/ParametreDegerListesi/',
    customeditbutton: `<button type="button" onclick="duzenleForm(#id#)"` +
        ` class="btn btn-outline-warning btn-sm btn-pill">` +
        `<i class="fa fa-edit"></i>Düzenle</button>`,
    saveurl: '/Tema/ParametreDegeriKaydet',
    formsubmittype: 'formdata',
    columns: [
        { title: "No", data: 'id' },
        { title: "Kodu", data: 'kodu' },
        { title: "İsim", data: 'isim' },
        { title: "Durum", data: 'durum',render:(data)=>"<button class='btn btn-outline-"+(data?'success':'danger')+"'>"+(data?'Veri var':'Veri yok')+"</button>" },
    ]
},
];
