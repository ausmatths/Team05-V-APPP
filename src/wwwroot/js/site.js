// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your Javascript code.

var selectedRow = null;
function onFormSubmit(e) {
    event.preventDefault();
    var formData = readFormData();
    if (selectedRow === null) {
        insertNewRecord(formData);
    }
    else {
        updateRecord(formData);
    }
    resetForm();
}

//Retrieve the data
function readFormData() {
    var formData = {};
    formData["@Model.Product.Title"] = document.getElementById("@Model.Product.Title").value;
    formData["@Model.Product.Description"] = document.getElementById("@Model.Product.Description").value;
    formData["@Model.Product.Quantity"] = document.getElementById("@Model.Product.Quantity").value;
    formData["@Model.Product.Price"] = document.getElementById("@Model.Product.Price").value;
    return formData;
}

//Insert the data
function insertNewRecord(data) {
    var table = document.getElementById("storeList").getElementsByTagName("tbody")[0];
    var newRow = table.insertRow(table.length);
    var cell1 = newRow.insertCell(0);
        cell1.innerHTML = data.Product.Title;
    var cell2 = newRow.insertCell(1);
        cell2.innerHTML = data.Product.Description;
    var cell3 = newRow.insertCell(2);
        cell3.innerHTML = data.Product.Quantity;
    var cell4 = newRow.insertCell(3);
        cell4.innerHTML = data.Product.Price;
    var cell5 = newRow.insertCell(4);
        cell5.innerHTML = `<button onClick='onEdit(this)'>Edit</button> <button onClick='onDelete(this)'>Delete</button>`
}

//Edit the data
function onEdit(td) {
    selectedRow = td.parentElement.parentElement;
    document.getElementById('Product.Title').value = selectedRow.cells[0].innerHTML;
    document.getElementById('Product.Description').value = selectedRow.cells[1].innerHTML;
    document.getElementById('Product.Quantity').value = selectedRow.cells[2].innerHTML;
    document.getElementById('Product.Price').value = selectedRow.cells[3].innerHTML;
}

function updateRecord(formData) {
    selectedRow.cells[0].innerHTML = formData.Product.Title;
    selectedRow.cells[1].innerHTML = formData.Product.Description;
    selectedRow.cells[2].innerHTML = formData.Product.Quantity;
    selectedRow.cells[3].innerHTML = formData.Product.Price;
}

//Delete the data
function onDelete(td) {
    if (confirm('Do you want to delete this record?')) {
        row = td.parentElement.parentElement;
        document.getElementById('storeList').deleteRow(row.rowIndex);
    }
    resetForm();
}

//Reset the data
function resetForm() {
    document.getElementById('Model.Product.Title').value = '';
    document.getElementById('Model.Product.Description').value = '';
    document.getElementById('Model.Product.Quantity').value = '';
    document.getElementById('Model.Product.Price').value = '';
}