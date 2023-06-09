function encodeAndDecodeMessages() {
    
    const buttons = Array.from(document.querySelectorAll('#main div button'));
    const firstTextArea = Array.from(document.querySelectorAll('#main div textarea'))[0];
    const secondTextArea = Array.from(document.querySelectorAll('#main div textarea'))[1];
    console.log

    const encode = buttons[0];
    const decode = buttons[1];

    encode.addEventListener('click', encoder);
    decode.addEventListener('click', decoder);

    function encoder(event){
        
        let text = firstTextArea.value;

        let newText = '';

        for (const symbol of text) {
            
            newText += String.fromCharCode(symbol.charCodeAt(0) + 1);
        }

        secondTextArea.value = newText
        firstTextArea.value = '';
    }

    function decoder(event){

        let result = '';

        for (const symbol of secondTextArea.value) {
            result += String.fromCharCode(symbol.charCodeAt(0) - 1);
        }
        secondTextArea.value = result;
    }
  
    secondTextArea.value = '';

}