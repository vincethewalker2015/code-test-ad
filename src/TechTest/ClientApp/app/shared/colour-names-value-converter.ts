import { IColour } from '../people/interfaces/icolour';

export class ColourNamesValueConverter {

    toView(colours: IColour[]) {

        // TODO: Step 4
        //
        // Implement the value converter function.
        // Using the colours parameter, convert the list into a comma
        // separated string of colour names. The names should be sorted
        // alphabetically and there should not be a trailing comma.
        //
        // Example: 'Blue, Green, Red'

        var colourNames = [];
      var i;

      for (i = 0; i < colours.length; i++)
      {
          colourNames[i] = colours[i].name;
      }

      colourNames.sort();

      return colourNames.join(', ');
        

        // FORMER OPTION BELOW

        //let sortedColours = colours.sort(this.compare)

        //let sResult = '';
        //for (let i = 0; i < sortedColours.length; i++) {
          //  if (i == 0) {
            //    sResult = sortedColours[i].name + ', ';
            //}
            //else {
              //  sResult = sResult + sortedColours[i].name + ', '
            //}
        //}
        //return sResult;
    //}
    //private compare(n1, n2) {
      //  if (n1.name > n2.name) {
        //    return 1;
        //}

       // if (n1.name < n2.name) {
         //   return -1;
        //}

      //  return 0;
    //}
//}
    //    let sortedColours = colours.sort(this.compare)

    //    let sResult = '';
    //    for (let i = 0; i < sortedColours.length; i++) {
    //        if (i == 0) {
    //            sResult = sortedColours[i].name + ', ';
    //        }
    //        else {
    //            sResult = sResult + sortedColours[i].name + ', '
    //        }
    //    }

    //    return sResult;
    //}

    //private compare(a, b) {
    //    if (a.Name < b.Name) {

    //        return -1;
    //    }
    //    if (a.Name > b.Name) {
    //        return 1;
    //    }
    //    return 0;
    }
}