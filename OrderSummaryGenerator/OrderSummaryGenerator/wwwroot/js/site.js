// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function IsMXDDeliveryPlace() {
    txtDeliveryPlace = document.getElementById('deliveryPlace');
    txtIndications = document.getElementById('indications');
    if (document.getElementById('IsMXD').checked) {
        txtDeliveryPlace.value = 'Maxi Despensa de San Bartolo, Ilopango'; 
        txtDeliveryPlace.readonly = true;
    }
    else {
        txtDeliveryPlace.value = '';
        txtDeliveryPlace.readonly = false;
    }
}


