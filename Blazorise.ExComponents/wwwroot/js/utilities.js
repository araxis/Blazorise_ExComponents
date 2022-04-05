export function GetElementSize(element) {
   //const elementSizInfo = getBoundingClientRect();
   //     return {
   //         width: elementSizInfo.width,
   //         height: elementSizInfo.height
   //     };

   return {
                width: element.offsetWidth,
                height: element.offsetHeight
            };

};