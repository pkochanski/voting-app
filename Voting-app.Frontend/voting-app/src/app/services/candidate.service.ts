import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { Candidate } from '../models/candidate';
import { environment } from '../environments/environment';
import { Candidates } from '../models/candiadates';
import { Injectable } from '@angular/core';
@Injectable({
    providedIn: 'root',
  })
export class CandidateService{
    constructor(private http:HttpClient){}

    private candidates:BehaviorSubject<Candidates> = new BehaviorSubject(new Candidates());
    public candiates$ = this.candidates.asObservable();

    getCandidates():void{
        this.candidates.next({...this.candidates.value, isLoading:true});
        this.http.get<Candidate[]>(`${environment.apiUrl}/candidates`).subscribe({
            next:(result)=>{
                this.candidates.next({list:result, isLoading:false});
            }
        });
    }

    postCandidate(name:string):Observable<void>{
        return this.http.post<void>(`${environment.apiUrl}/candidates`,{name}).pipe(
            tap(()=>{
                this.getCandidates();
            })
        );
    }
}