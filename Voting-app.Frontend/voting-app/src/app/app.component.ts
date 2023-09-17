import { Component, OnInit } from '@angular/core';
import { CandidateService } from './services/candidate.service';
import { VoterService } from './services/voter.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  constructor(private candidateService: CandidateService, private voterService: VoterService){}
  ngOnInit(): void {
    this.candidateService.getCandidates();
    this.voterService.getVoters();
  }
  title = 'voting-app';
}
