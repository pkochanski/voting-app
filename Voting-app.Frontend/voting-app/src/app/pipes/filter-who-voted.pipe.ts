import { Pipe, PipeTransform, isStandalone } from '@angular/core';
import { Voter } from '../models/voter';

@Pipe({
  name: 'filterWhoVoted',
  standalone:true
})
export class FilterWhoVotedPipe implements PipeTransform {

  transform(values: Voter[]): any[] {
    return values.filter(v => !v.hasVoted);
  }

}