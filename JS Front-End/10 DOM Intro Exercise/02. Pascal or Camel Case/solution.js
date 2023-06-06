function solve() {
  const input = document.getElementById('text').value;
  const namingConvention = document.getElementById('naming-convention').value;
  const result = document.getElementById('result');

  const pascalCase = (text) => text.split(' ')
          .map((w) => w[0].toUpperCase() + w.slice(1).toLowerCase())
          .join('');

  const camelCase = (text) =>{
    text = pascalCase(text);

    return text[0].toLowerCase() + text.slice(1);
  }


  if (namingConvention === 'Pascal Case'){
      result.textContent = pascalCase(input);
  }
  else if (namingConvention === 'Camel Case'){
    result.textContent = camelCase(input);
  }else{
    result.textContent = 'Error!';
  }

}