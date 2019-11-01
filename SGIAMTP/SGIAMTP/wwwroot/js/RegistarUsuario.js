function archivoFotoUsuario() {

    var selectedFile = document.getElementById("fotoUsuario").files;

    if (selectedFile.length > 0) {

        var fileToLoad = selectedFile[0];
        var fileReader = new FileReader();
        var base64;

        fileReader.onload = function (fileLoadedEvent) {
            base64 = fileLoadedEvent.target.result;
            //document.getElementById("data").innerHTML = base64;
            console.log(base64);
        }
    };

    fileReader.readAsDataURL(fileToLoad);
};

function verContenido(){
    var verContenido = document.getElementById("fotoUsuario").value;
    alert(verContenido);
}