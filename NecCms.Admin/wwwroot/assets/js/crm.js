
$(() => loadPage())

var table, tpage;
loadPage = () => {
    var page = pages.find(f => f.url.toLowerCase() == window.location.pathname.toLowerCase())

    if (page) {
        pageInit(page);
    }
}

pageInit = (page) => {
    tpage = page;
    document.title = page.name;
    $('.pageHeader').text(page.name);
    if (page.parentname)
        $('.parentHeader').text(page.parentname);
    else
        $('.parentHeader').remove();

    if (page.formPageUrl)
        $('#formOpenButton')
            .removeAttr('data-toggle')
            .removeAttr('data-target')
            .removeAttr('onclick')
            .attr('href', page.formPageUrl);

    if (page.columns)
        table = $('#datatable').DataTable({
            ajax: (page.tableurl || (page.url + '/List')),
            columns: [...page.columns, {
                title: 'İşlemler',
                data: 'id',
                render: (data) => page.customeditbutton ? page.customeditbutton.replace('#id#', data)
                    : `<button type="button" data-toggle="modal" onclick="setFormId(${data})"` +
                    ` data-target="#editModal" class="btn btn-outline-warning btn-sm btn-pill">` +
                    `<i class="fa fa-edit"></i>Düzenle</button>`
            }],
        });

    if (page.form)
        $('#editModalRow').append(prepareForm(page.form));

    if (page.formsubmittype == 'formdata') {
        $('#editModalForm').attr('action', (tpage.saveurl || (tpage.url.replace('/Index', '') + '/Save')))
        $('#editModalForm').attr('enctype', 'multipart/form-data')
        $('#editModalForm').attr('onsubmit', 'FileUpload(this);return false;')
    }

    $('#editModalForm').on('submit', submitForm)

    initdatepicker()


}


initdatepicker = () => $('.date').datepicker({
    language: 'tr',
    autoclose: true,
    defaultDate: formatDateLocate(new Date().toISOString())
});

submitForm = (e) => {
    e.preventDefault();
    showToaster(1)
    if (tpage.customSaveFunc) {
        eval(tpage.customSaveFunc);
        return;
    }

    if (tpage.formsubmittype !== 'formdata') {
        var model = $('#editModalForm').serializeFormJSON();
        body = JSON.stringify({
            ...model,
            Id: tid
        });

        fetch((tpage.saveurl || (tpage.url.replace('/Index', '') + '/Save')), {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body
        }).then(res => {
            if (res.status == 500) {
                return false;
            } else {
                showToaster(2)
                return res.json()
            }
        }).then(res => {
            if (res.data) {
                if (tpage.customsuccessfun) {
                    eval(tpage.customsuccessfun)
                }
                else {
                    table.ajax.reload();
                    $('#editModal').modal('hide')
                }
            }
        })
    }
}

async function FileUpload(oFormElement) {
    showToaster(1)
    const formData = new FormData(oFormElement);

    try {
        const response = await fetch(oFormElement.action, {
            method: 'POST',
            body: formData
        });

        if (response.ok) {
            if (tpage.customsuccessfun) {
                eval(tpage.customsuccessfun)
            }
            else {
            showToaster(2)
                table.ajax.reload();
                $('#editModal').modal('hide')
            }
        }

    } catch (error) {
        console.error('Error:', error);
    }
}

silitem = () => {
        Swal.fire({
            title: 'Kaldırmak istediğinize emin misiniz?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Evet!',
            cancelButtonText: 'Hayır'
        }).then((result) => {
            if (result.value) {

                showToaster(1)
                fetch((tpage.silurl || tpage.url.replace('/Index', '') + '/Kaldir'), {
                    method: 'post',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        Id: tid
                    })
                }).then(res => {
                    if (res.status == 500) {
                        return false;
                    } else {
                        showToaster(2)
                        return res.json()
                    }
                }).then(res => {
                    if (res) {
                        table.ajax.reload();
                        $('#editModal').modal('hide')
                        Swal.fire(
                            'Başarılı!',
                            'Kaldırıldı.',
                            'success'
                        )
                    }
                })
            }
        })
}

var tid;
setFormId = (id) => {
    if (id == 0) $('#editModalDelete').css('display', 'none')
    else $('#editModalDelete').css('display', 'flex')

    tid = id;
    $("#editModalForm").trigger('reset');
    $('#editModalId').val(id);
    if (id != 0)
        fetch((tpage.tableurl || (tpage.url + '/List/')) + id)
            .then(res => res.json())
            .then(res => res.data.map(item => Object.keys(item).map(name => $('#' + name).val(setValue(name, item[name])).change())))

}

setValue = (name, value) => {
    if (name.toLowerCase().match('tarih'))
        return formatDateLocate(value);
    else
        return value;
}

prepareForm = (formList) => {
    var formHtml = formList.map(item => formElements(item));
    return formHtml;
}
formElements = (item) => {
    var elementHtml = '<div class="form-group" style="' + (item.style || "") + '" >';

    if (!item.hidden)
        elementHtml += `<label for="${item.id}">${item.name}</label>`

    switch (item.type) {
        case 'input':
            elementHtml += `<input class="form-control ${item.class || ""}" id="${item.id}" name="${item.id}" placeholder="${item.placeholder || item.name}" `

            if (item.subtype)
                elementHtml += ` type="${item.subtype.split(',')[0]}"`
            else
                elementHtml += ` type=""text"`

            if (item.pattern)
                elementHtml += ` pattern="${item.pattern}"`

            if (item.maxLength)
                elementHtml += ` maxLength="${item.maxLength}"`

            if (item.hidden)
                elementHtml += ` hidden`

            if (item.required)
                elementHtml += ` required`

            if (item.value != undefined)
                elementHtml += ` value="${item.value}"`

            if (item.onchange)
                elementHtml += ` onchange="${item.onchange}" onkeypress="this.onchange();" onpaste="this.onchange();" oninput="this.onchange();"`

            if (item.dataset)
                elementHtml += ` dataset="${item.dataset}"`

            elementHtml += '>'
            break;
        case 'textarea':
            elementHtml += `<textarea class="form-control" id="${item.id}" name="${item.id}"` +
                ` rows="3" maxLength="${item.maxLength}" ></textarea>`
            break;
        case 'select':
            if (item.ajax)
                fetch(item.ajax)
                    .then(res => res.json())
                    .then(res => {
                        $(`#${item.id}`).select2({
                            data: res.data.map(s => ({
                                id: s.id,
                                text: s[item.text],
                                data: s.data
                            }))
                        })
                    })

            setTimeout(() => $(`#${item.id}`).select2({
                width: 'resolve',
                placeHolder: item.name,
                data: item.data
            }), 100)

            elementHtml += `<select class="form-control" ${item.required ? `required` : ""}` +
                ` ${item.subinputval ? `subinputval="${item.subinputval}"` : ""}` +
                `${item.onchange ? `onchange="${item.onchange}"` : ""}   ` +
                `${item.dataset ? `dataset="${item.dataset}"` : ""} ` +
                `${item.subonchange ? `subonchange="${item.subonchange}"` : ""} ` +
                `style="width:100%" ${item.multi ? 'multiple="multiple"' : ""}` +
                ` name="${item.id}" id="${item.id}"></select>` +
                `<div class="row"><div class="col-md-12" id="${item.id + "after"}" ></div></div>`
            break;

        case 'date':

            elementHtml += `<input ${item.onchange ? `onchange="${item.onchange}"` : ""}   type="text" class="form-control date" id="${item.id}" ${item.required || item.required == null ? "required" : ""} name="${item.id}" >`;
            break;

        case 'datetime':

            elementHtml += `<div class="row"><input ${item.onchange ? `onchange="${item.onchange}"` : ""}   type="text" class="form-control col-md-5 mr-2 ml-2 float-left date" placeholder="Tarih" id="${item.id}" ${item.required || item.required == null ? "required" : ""} name="${item.id}" >`;
            elementHtml += `<input type="number" class="form-control col-md-2 mr-2 float-left" placeholder="Saat" id="saat_${item.id}" ${item.required || item.required == null ? "required" : ""} >`;
            elementHtml += `<input type="number" class="form-control col-md-2 mr-2 float-left" placeholder="Dakika" id="dakika_${item.id}" ${item.required || item.required == null ? "required" : ""} > </div>`;
            break;


        case 'inputlist':
            fetch(item.ajax)
                .then(res => res.json())
                .then(res => res.data.map(s => ({
                    id: s.id,
                    text: s[item.text]
                })).map(value => $(`#${item.id}`).append(formElements({
                    type: 'input',
                    required: item.required,
                    value: 0,
                    subtype: item.subtype,
                    id: item.inputid,
                    onchange: item.onchange,
                    class: item.id,
                    name: value.text,
                    style: item.inputstyle
                }))))

            elementHtml += `<div class="row"><div class="col-md-12" id="${item.id}" ></div></div>`;

            break;
        case 'html':
            elementHtml += item.html
            break;
        default:
    }
    return elementHtml + '</div>';
}

showToaster = (id) => {
    if (id === 1)
        id = "#bekletoast";
    if (id === 2)
        id = "#basarilitoast";

    $(id).toast('show')
    setTimeout(() => $(id).toast('hide'), 2000);
}


formatDateLocate = (date) => date.substring(8, 10) + "." + date.substring(5, 7) + "." + date.substring(0, 4)
formatDateIso = (date) => date.substring(6, 10) + "-" + date.substring(3, 5) + "-" + date.substring(0, 2)

selectInputsChanged = (current) => {
    var itemid = "#" + current.id;
    $(itemid + "after").empty();
    $(current).select2('data').map(item => $(itemid + "after").append(formElements({
        type: 'input',
        dataset: $(itemid).attr('dataset') ? item.data[$(itemid).attr('dataset')] : null,
        subtype: 'number,float',
        id: current.id + '[]',
        class: current.id,
        onchange: $(current).attr('subonchange'),
        name: item.text,
        required: $(current).attr('required'),
        style: 'width: 30%;float: left;margin-left: 5px;',
    })));
}
