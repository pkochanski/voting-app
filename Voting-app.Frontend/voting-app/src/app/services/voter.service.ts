import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { environment } from '../environments/environment';
import { Injectable } from '@angular/core';
import { Voters } from '../models/voters';
import { Voter } from '../models/voter';
import {tap} from 'rxjs';
@Injectable({
    providedIn: 'root',
  })
export class VoterService{
    constructor(private http:HttpClient){}

    private voters:BehaviorSubject<Voters> = new BehaviorSubject(new Voters());
    public voters$ = this.voters.asObservable();

    getVoters():void{
        this.voters.next({...this.voters.value, isLoading:true});
        this.http.get<Voter[]>(`${environment.apiUrl}/voters`).subscribe({
            next:(result)=>{
                this.voters.next({list:result, isLoading:false});
            }
        });
    }

    postVoter(name:string):Observable<void>{
        return this.http.post<void>(`${environment.apiUrl}/voters`,{name}).pipe(
            tap(()=>{
                this.getVoters();
            })
        );
    }
}