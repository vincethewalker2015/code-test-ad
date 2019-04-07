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
        let sortedColours = colours.sort(this.compare)

        let result = '';
        for (let i = 0; i < sortedColours.length; i++) {
            if (i == 0) {
                result = sortedColours[i] + ', ';
            }
            else {
                result = result + sortedColours[i] + ', '
            }
        }

        return result;
    }

    private compare(a, b) {
        if (a.Name.toLowerCase() < b.Name.toLowerCase()) {
            return -1;
        }
        if (a.Name.toLowerCase() > b.Name.toLowerCase()) {
            return 1;
        }
        return 0;
    }

}
