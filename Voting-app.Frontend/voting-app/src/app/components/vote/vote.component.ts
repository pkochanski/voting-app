import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VoteService } from 'src/app/services/vote.service';
import { VoterService } from 'src/app/services/voter.service';
import { CandidateService } from 'src/app/services/candidate.service';
import { FormControl, FormGroup, Validators,ReactiveFormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import { MatButtonModule} from '@angular/material/button';
import {MatSelectModule} from '@angular/material/select';
import {MatFormFieldModule} from '@angular/material/form-field';
import { FilterWhoVotedPipe } from 'src/app/pipes/filter-who-voted.pipe';

@Component({
  selector: 'app-vote',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule,MatInputModule, MatButtonModule, MatSelectModule, MatFormFieldModule,
  FilterWhoVotedPipe],
  templateUrl: './vote.component.html',
  styleUrls: ['./vote.component.scss']
})
export class VoteComponent {
  constructor(private voteService: VoteService, private voterService:VoterService,private candidateService:CandidateService){}

  candidates$ = this.candidateService.candiates$;
  voters$ = this.voterService.voters$;
  voteMode:boolean = false;

  voteForm = new FormGroup({
    voterId: new FormControl<number | null>(null,Validators.required),
    candidateId: new FormControl<number | null>(null,Validators.required)
  });

  toggleVoteMode(){
    this.voteMode = !this.voteMode;
  }
  vote(){
    this.voteService.vote(this.voteForm.controls.voterId.value!,this.voteForm.controls.candidateId.value!).subscribe({
      next:()=>{
        this.voteForm.reset();
        this.toggleVoteMode();
      }
    })
  }
}
