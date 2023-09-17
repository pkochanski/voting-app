import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CandidateService } from 'src/app/services/candidate.service';
import {MatTableModule} from '@angular/material/table';
import { FormControl, FormGroup, Validators,ReactiveFormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
@Component({
  selector: 'app-candidates',
  standalone: true,
  imports: [CommonModule, MatTableModule, MatInputModule,ReactiveFormsModule, MatIconModule, MatButtonModule],
  templateUrl: './candidates.component.html',
  styleUrls: ['./candidates.component.scss']
})
export class CandidatesComponent {
  constructor(private candidateService: CandidateService){}

  candidates$ = this.candidateService.candiates$;

  addCandidateForm = new FormGroup({
    name:new FormControl<string | null>("",Validators.required)
  })

  addMode = false;

  toggleAddMode(){
    this.addMode = !this.addMode;
  }

  addCandidate(){
    this.candidateService.postCandidate(this.addCandidateForm.controls.name.value!).subscribe({
      next:()=>{
        this.addCandidateForm.reset();
        this.toggleAddMode();
      }
    })
  }

}
