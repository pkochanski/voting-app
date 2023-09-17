import { HttpClient } from '@angular/common/http';
import { Observable} from 'rxjs';
import { environment } from '../environments/environment';
import { Injectable } from '@angular/core';
import {tap} from 'rxjs';
import { VoterService } from './voter.service';
import { CandidateService } from './candidate.service';
@Injectable({
    providedIn: 'root',
  })
export class VoteService{
    constructor(private http:HttpClient, private voterService: VoterService, private candidateService:CandidateService){}

    vote(voterId:number, candidateId:number):Observable<void>{
        return this.http.post<void>(`${environment.apiUrl}/voters/vote`,{voterId,candidateId}).pipe(
            tap(()=>{
                this.voterService.getVoters();
                this.candidateService.getCandidates();
            })
        );
    }
}