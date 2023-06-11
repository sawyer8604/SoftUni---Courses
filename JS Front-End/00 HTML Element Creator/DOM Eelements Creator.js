// type = string
// content = string (text content)
// id == string
//classes = array of strings
// attributes = objects
function createElement(type, content, parentNode, id, classes, attributes){
    const htmlElement = document.createElement(type);

    if(content && type !== 'input'){
        htmlElement.textContent = content;
    }

    if(content && type === 'input'){
        htmlElement.value = content;
    }

    if(id){
        htmlElement.id = id;
    }
//['list', 'item']
    if(classes){
        htmlElement.classList.add(...classes);
    }

    if(parentNode){
        parentNode.appendChild(htmlElement);
    }

// {img: 'link to image', }
    if(attributes){
        for (const key in attributes) {
           htmlElement.setAttribute(key, attributes[key]);
        }
    }

    return htmlElement;

}