import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CandidatesComponent } from './components/candidates/candidates.component';
import { HttpClientModule } from '@angular/common/http';
import { VotersComponent } from './components/voters/voters.component';
import { VoteComponent } from './components/vote/vote.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    CandidatesComponent,
    HttpClientModule,
    VotersComponent,
    VoteComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
