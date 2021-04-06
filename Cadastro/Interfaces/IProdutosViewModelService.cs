using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
    public interface IProdutosViewModelService
    {       
        IEnumerable<ProdutoViewModel> GetAll();
        void Insert(ProdutoViewModel viewModel);
        void Update(ProdutoViewModel viewModel);
        
    }
}
