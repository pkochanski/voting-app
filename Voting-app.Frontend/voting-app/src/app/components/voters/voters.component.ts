import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VoterService } from 'src/app/services/voter.service';
import { FormControl, FormGroup, Validators,ReactiveFormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';

@Component({
  selector: 'app-voters',
  standalone: true,
  imports: [CommonModule, MatInputModule,ReactiveFormsModule, MatIconModule, MatButtonModule],
  templateUrl: './voters.component.html',
  styleUrls: ['./voters.component.scss']
})
export class VotersComponent {
  constructor(private votersService: VoterService){}

  voters$ = this.votersService.voters$;
  
  addVoterForm = new FormGroup({
    name:new FormControl<string | null>("",Validators.required)
  })

  addMode = false;

  toggleAddMode(){
    this.addMode = !this.addMode;
  }

  addVoter(){
    this.votersService.postVoter(this.addVoterForm.controls.name.value!).subscribe({
      next:()=>{
        this.addVoterForm.reset();
        this.toggleAddMode();
      }
    })
  }
}
