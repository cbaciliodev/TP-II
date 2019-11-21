$(document).ready(function () {

    getlistcombobox();
    getlistpuntajes(false);

});
//var crear = function (iddni) {
//    window.location.href = url.CreateCalif + '?iddni=' + iddni;
//};
var calificar = function (idt) {
    //var a = $("td[aria-describedby=table-listar-puntajes_puntajeTotal]").length;
    //var list = [];
    //for (let i = 0; i < a; i++) {
    //    list[i] = parseInt($($("td[aria-describedby=table-listar-puntajes_puntajeTotal]")[i]).text());
    //}
    //var maxValue = Math.max.apply(null, list);
    //var position = list.indexOf(maxValue);
    var model = $("td[aria-describedby=table-listar-puntajes_Opciones]").parent();
    var result = {
        codigoTanda: model.find("[aria-describedby=table-listar-tandas_idTanda]").text(),
        categoria: model.find("[aria-describedby=table-listar-tandas_categoria]").text(),
        modalidad: model.find("[aria-describedby=table-listar-tandas_modalidad]").text()
    };
    var url = {
        CreateCalif: '@Url.Action("Create","TPuntajes")'
    }
    localStorage.setItem('ct', result.codigoTanda);
    localStorage.setItem('cat', result.categoria);
    localStorage.setItem('mod', result.modalidad);
    window.location.href = "/TPuntajes/Create/" + '?idt=' + idt;
};
var getlistcombobox = function () {
    $.ajax({
        url: "/TTandas/GetComboBox",
        type: "GET",
        //data: { id: id },
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            var selecttanda = $('#tandaa'); // va buscar en todo el doc algun elemento que tenga el id 
            selecttanda.find('option').remove(); // son los elementos
            selecttanda.append('<option value="">' + 'Seleccione' + '</option>');
            $.each(response.tand, function (key, value) { //temp es la lista que va recorrer 
                selecttanda.append('<option value=' + value.pkItCodTan + '>' + value.pkItCodTan + '</option>');
            });

        },
        error: function (response) {

        }
    });
};
var getlistpuntajes = function (flag) {
    var tanda = 0;
    var descripcion = null;
    var descripcion1 = null;
    if (flag) {
        tanda = $("#tandaa").val();

    }
    $.ajax({
        url: "/TTandas/MostrarTanda",
        type: "GET",
        data: { idtanda: tanda },
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            if (flag) {
                //la primera ves que entre sera para listar y el flag sera false , por ende lo redireccionará a tableAsistencia y si agrega o elimina reutilizaremos esta funcionon para no crear mas y no tener mas codigo en vano por ende el flag sera true cuando creemos o eliminemos.
                $('#table-listar-tandas').jqGrid('clearGridData');
                $('#table-listar-tandas').jqGrid('setGridParam', { data: response.punta });
                $('#table-listar-tandas').trigger('reloadGrid');
                $('#table-listar-tandas').trigger('reloadGrid', { page: 1 });
            } else {
                tablepuntajes(response.punta);
            }
        },
        error: function (response) {
        }
    });
};
refreshPager = function (selectorTable, selectorPager) {
    $(selectorTable).navGrid(selectorPager, { add: false, edit: false, del: false, search: false, refresh: true });
};
var tablepuntajes = function (response) {
    $("#table-listar-tandas").jqGrid({
        data: response,
        datatype: "local",
        rowNum: 10,
        rowList: [10, 20, 30],
        colModel: [
            { label: 'Codigo Tanda', name: 'idTanda', key: true },
            { label: 'Categoria', name: 'categoria' },
            { label: 'Modalidad', name: 'modalidad' },
            { label: 'tipo Tanda', name: 'tipo_tanda' },
            { label: 'estado', name: 'estado' },
            {
                label: 'Opciones', name: 'Opciones', formatter: function (cellvalue, options, rowObject) {
                    var norma = '<button onclick="calificar(' + options.rowId + ')", <a href="#" class="btn btn-primary btn-default"><span class="glyphicon glyphicon-circle-arrow-right"></span> Calificar</a></button>';
                    return norma;
                }
            }
            //{ label: 'Estado', name: 'Estado' },
            //{ label: 'Acion', name: 'puntajeTotal' }

        ],
        onSelectRow: function () {
            //var rowKey = $("#table-listar-norma").jqGrid('getGridParam', "selrow");
            //$("#radio-grid-norma-item-" + rowKey).prop("checked", true);
            //selectedNormaId = rowKey;
        },
        loadComplete: function () {
            //if (selectedNormaId > 0) {
            //    var grid = $("#table-listar-norma");
            //    grid.setSelection(selectedNormaId);
            //    $('#radio-grid-norma-item-' + selectedNormaId).attr('checked', true);
            //}

            //$('.ui-pg-input').keydown(function (event) { onlyNumbersWithEnterKeycode(event) });
            //$('.ui-pg-input').keyup(function (event) {
            //    validarNumeroMaximoPaginacion(event, 'sp_1_pager-listar-norma');
            //});
        },
        cmTemplate: { sortable: false },
        pager: "#pager-listar-tandas"
    });

    refreshPager("#table-listar-tandas", "#pager-listar-tandas");

};