function checkButton01() {    

    if(document.getElementById('juridica').checked){
        var cnpj = document.getElementById("cnpj")
        cnpj.disabled = false;
        var cpf = document.querySelector(".cpf")
        cpf.disabled = true;
        var radioBtn = document.querySelector("#fisica")
        radioBtn.checked = false ;
        var nascimento = document.querySelector(".nascimento")
        nascimento.disabled = true;
    }
}  

function checkButton02() {    
    
    if(document.getElementById('fisica').checked) { 
        var cpf = document.querySelector(".cpf")
        cpf.disabled = false;
        var cnpj = document.getElementById("cnpj")
        cnpj.disabled = true;
        var radioBtn = document.querySelector("#juridica")
        radioBtn.checked = false ;
        var nascimento = document.querySelector(".nascimento")
        nascimento.disabled = false;
    }
}   

function clicado(){
    alert("Mandou")
}