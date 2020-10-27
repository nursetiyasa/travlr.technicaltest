window.onload = function () {
    if (window.location.pathname === '/Booking/Booking') {
        showTotalPrice();
        document.getElementById('selectDateFrom').setAttribute('autocomplete', 'off');
        document.getElementById('selectDateTo').setAttribute('autocomplete', 'off');
    }
};
function showTotalPrice() {
    var startDate = document.getElementById('selectDateFrom').value;
    var endDate = document.getElementById('selectDateTo').value;
    var firstName = document.getElementById('firstName').value;
    var lastName = document.getElementById('lastName').value;
    var totalPriceLabel = document.getElementById('totalPriceLabel');
    if ((startDate !== "") && (endDate !== "") && (firstName !== "") && (lastName !== "")) {
        totalPriceLabel.classList.remove('d-none');
    } else {
        totalPriceLabel.classList.add('d-none');
    }
}