import { IColour } from '../people/interfaces/icolour';

export class ColourNamesValueConverter {

  toView(colours: IColour[]) {
     // TODO: Step 4
   var colourNames = [];
      var i;

      for (i = 0; i < colours.length; i++)
      {
          colourNames[i] = colours[i].name;
      }

      colourNames.sort();

      return colourNames.join(', ');
  }

}
