import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SituacaoLinhasComponent } from './situacao-linhas.component';

describe('SituacaoLinhasComponent', () => {
  let component: SituacaoLinhasComponent;
  let fixture: ComponentFixture<SituacaoLinhasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SituacaoLinhasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SituacaoLinhasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
