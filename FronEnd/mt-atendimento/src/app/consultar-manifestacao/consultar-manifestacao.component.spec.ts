import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultarManifestacaoComponent } from './consultar-manifestacao.component';

describe('ConsultarManifestacaoComponent', () => {
  let component: ConsultarManifestacaoComponent;
  let fixture: ComponentFixture<ConsultarManifestacaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultarManifestacaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultarManifestacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
