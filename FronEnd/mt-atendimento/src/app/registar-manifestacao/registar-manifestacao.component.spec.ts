import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistarManifestacaoComponent } from './registar-manifestacao.component';

describe('RegistarManifestacaoComponent', () => {
  let component: RegistarManifestacaoComponent;
  let fixture: ComponentFixture<RegistarManifestacaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistarManifestacaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistarManifestacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
